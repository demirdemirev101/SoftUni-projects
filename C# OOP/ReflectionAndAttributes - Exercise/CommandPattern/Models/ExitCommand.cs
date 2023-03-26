namespace CommandPattern.Models
{
    using System;
    using CommandPattern.Core.Contracts;

    public class ExitCommand : ICommand
    {
        private const int defaultErrorCode= 0;
        public string Execute(string[] args)
        {
            Environment.Exit(defaultErrorCode);
            return null;
        }
    }
}
