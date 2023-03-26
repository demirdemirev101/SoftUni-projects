namespace Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    public class Spy
    {
        public string StealFieldInfo(string classToInvestigate, params string[] requestedFields)
        {
            StringBuilder sb = new StringBuilder();
            Type type = Type.GetType(classToInvestigate);
            FieldInfo[] fieldInfo = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            Object classInstance = Activator.CreateInstance(type, new object[] { });

            sb.AppendLine($"Class under investigation: {classToInvestigate}");
            foreach (FieldInfo field in fieldInfo.Where(f => requestedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }
        public string AnalyzeAccessModifiers(string classToInvestigate)
        {
            Type classType = Type.GetType(classToInvestigate);
            
            FieldInfo[] fieldInfos=classType.GetFields(BindingFlags.Instance|BindingFlags.Static|BindingFlags.Public);
            MethodInfo[] publicMethodsInfo = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] nonPublicMethodsInfo = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            
            StringBuilder sb = new StringBuilder();

            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                sb.AppendLine($"{fieldInfo.Name} must be private!");
            }
            foreach (MemberInfo publicMethodInfo in publicMethodsInfo.Where(m=>m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{publicMethodInfo.Name} have to be public!");
            }
            foreach (MemberInfo nonPublicMethodInfo in nonPublicMethodsInfo.Where(m=>m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{nonPublicMethodInfo.Name} have to be private!");
            }
            return sb.ToString().Trim();
        }
        public string RevealPrivateMethods(string classToInvestigate)
        {
            Type type = Type.GetType(classToInvestigate);
            MethodInfo[] methodInfos=type.GetMethods(BindingFlags.Instance|BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {type.FullName}");
            sb.AppendLine($"Base Class: {type.BaseType.Name}");
            foreach (MethodInfo methodInfo in methodInfos)
            {
                sb.AppendLine($"{methodInfo.Name}");
            }
            return sb.ToString().Trim();
        }
        public string CollectGettersAndSetters(string classToInvestigate)
        {
            Type type= Type.GetType(classToInvestigate);
            MethodInfo[] methodInfos=type.GetMethods(BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Public);
            StringBuilder sb = new StringBuilder();
            foreach (MethodInfo methodInfo in methodInfos.Where(m=>m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{methodInfo.Name} will return {methodInfo.ReturnType}");
            }
            foreach (MethodInfo methodInfo in methodInfos.Where(m => m.Name.StartsWith("set"))) 
            {
                sb.AppendLine($"{methodInfo.Name} will set field of {methodInfo.GetParameters().First().ParameterType}");
            }
                return sb.ToString().Trim();
        }
    }
}
