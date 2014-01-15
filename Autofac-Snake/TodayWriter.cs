using System;

namespace Autofac_Snake
{
    public interface IOutput
    {
        void Write(string content);
    }

    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }

    public interface IDateWriter
    {
        void WriteDate();
    }

    class TodayWriter : IDateWriter
    {
        private readonly IOutput output;
        public TodayWriter(IOutput output)
        {
            this.output = output;
        }

        public void WriteDate()
        {
            output.Write(DateTime.Today.ToShortDateString());
        }
    }
}
