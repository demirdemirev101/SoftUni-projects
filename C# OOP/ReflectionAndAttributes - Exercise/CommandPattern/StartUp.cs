namespace CommandPattern
{
    using CommandPattern.Core;
    using CommandPattern.Core.Contracts;
    using Core.Contracts;
    using Utilities;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();
        }
    }
}
