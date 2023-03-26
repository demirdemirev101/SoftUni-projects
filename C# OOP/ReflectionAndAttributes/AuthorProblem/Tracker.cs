namespace AuthorProblem
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(Tracker);
            MethodInfo[] methodInfos=type.GetMethods(BindingFlags.Instance|BindingFlags.Static|BindingFlags.Public);
            foreach (var methodInfo in methodInfos)
            {
                if (methodInfo.CustomAttributes.Any(m=>m.AttributeType==typeof(AuthorAttribute)))
                {
                    var attributes=methodInfo.GetCustomAttributes(false);
                    foreach (AuthorAttribute attribute in attributes)
                    {
                        Console.WriteLine($"{methodInfo.Name} is written by {attribute.Name}");
                    }
                }
            }
        }
    }
}
