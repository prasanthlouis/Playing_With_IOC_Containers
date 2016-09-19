using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.cs
{
    public interface IConsoleDummyWriter
    {
        void WriteHereDummy(string text);
    }
    public class ConsoleDummyWriter : IConsoleDummyWriter
    {
        public void WriteHereDummy(string text)
        {
            Console.WriteLine(text);
        }
    }
}
