using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalDI
{
    public interface IExternalConsoleDummyWriter
    {
        void DontWriteHereAgainDummy(string text);
    }
    public class ExternalConsoleDummyWriter : IExternalConsoleDummyWriter
    {
        public void DontWriteHereAgainDummy(string text)
        {
            Console.WriteLine(text);
        }

    }
}
