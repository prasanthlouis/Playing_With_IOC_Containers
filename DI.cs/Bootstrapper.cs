using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace DI.cs
{
    public class Bootstrapper
    {
        static void Main(string[] args)
        {
            var application = Container.For<InterfaceScanner>();
            var _managerInstance = application.GetInstance<Manager>();
            _managerInstance.DoSomeStuff("Hit Me");
        }
    }
}
