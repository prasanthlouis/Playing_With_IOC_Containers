using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalDI;
using ExternalDIBreak;

namespace DI.cs
{
    public class Manager
    {
        private IConsoleDummyWriter _consoleDummyWriter;
        private IExternalConsoleDummyWriter _externalConsoleDummyWriter;
        private WeirdBreakConsoleDummyWriter _externalBreakConsoleDummyWriter;
        public Manager(IConsoleDummyWriter consoleDummyWriter, IExternalConsoleDummyWriter externalConsoleDummyWriter, WeirdBreakConsoleDummyWriter externalBreakConsoleDummyWriter)
        {
            _consoleDummyWriter = consoleDummyWriter;
            _externalConsoleDummyWriter = externalConsoleDummyWriter;
            _externalBreakConsoleDummyWriter = externalBreakConsoleDummyWriter;
        }

        public void DoSomeStuff(string text)
        {
           _consoleDummyWriter.WriteHereDummy(text);
           _externalConsoleDummyWriter.DontWriteHereAgainDummy(text);
           _externalBreakConsoleDummyWriter.WeDidItAgainDummy(text);
           Console.ReadLine();
        }
    }
}
