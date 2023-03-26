namespace CommandPattern.Utilities
{
    using CommandPattern.Core.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens=args.Split(' ');    
            string commandName=tokens[0];
            string[] invokeTokens = tokens.Skip(1).ToArray();

            Assembly assembly=Assembly.GetEntryAssembly();
            Type intendedTokensType = assembly.GetTypes().FirstOrDefault(t => t.Name == $"{commandName}Command");
            if (intendedTokensType==null)
            {
                throw new InvalidOperationException("Invalid command type!");
            }
            MethodInfo executeMethodInfo=intendedTokensType
                .GetMethods(BindingFlags.Instance|BindingFlags.Public)
                .FirstOrDefault(m => m.Name == "Execute");
            if (executeMethodInfo==null)
            {
                throw new InvalidOperationException("Command does not implement required pattern! Try implement ICommand interface instead");
            }
            
            object tokenInstance=Activator.CreateInstance(intendedTokensType);
            string result=(string)executeMethodInfo
                .Invoke(tokenInstance, new object[] { invokeTokens });
           
            return result;
        }
    }
}
