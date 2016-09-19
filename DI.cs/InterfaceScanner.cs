using StructureMap;
using System;
using ExternalDIBreak;

namespace DI.cs
{
    public class InterfaceScanner : Registry
    {
        public InterfaceScanner()
        {
                Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                    x.AssembliesFromPath(AppDomain.CurrentDomain.BaseDirectory,c => c.FullName.StartsWith("Ex"));
                });
            For<WeirdBreakConsoleDummyWriter>().Use<ExternalBreakConsoleDummyWriter>();


        }
    }
}
