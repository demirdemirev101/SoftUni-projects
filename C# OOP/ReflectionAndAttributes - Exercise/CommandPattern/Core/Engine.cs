namespace CommandPattern.Core
{
    using System;

    using IO.Contracts;
    using Contracts;
    using CommandPattern.IO;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly ICommandInterpreter cmdInterpreter;
        private Engine()
        {
            reader = new Reader();
            writer = new Writer();
        }
        public Engine(ICommandInterpreter commandInterpreter) : this()
        {
            cmdInterpreter = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    string inputLine = this.reader.ReadLine();
                    string result = this.cmdInterpreter.Read(inputLine);
                    this.writer.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
