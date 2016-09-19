using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalDIBreak
{
        public interface WeirdBreakConsoleDummyWriter
        {
            void WeDidItAgainDummy(string text);
        }
        public class ExternalBreakConsoleDummyWriter : WeirdBreakConsoleDummyWriter
        {
            public void WeDidItAgainDummy(string text)
            {
                Console.WriteLine(text);
            }

        }
    
}
