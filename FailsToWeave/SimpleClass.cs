using FailsToWeave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: WeaveAllMethodsInAssemblyAttribute()]

namespace FailsToWeave
{
    public class SimpleClass
    {
        public delegate void ThreadFinishedEventHandler();

        public struct MyStruct
        {
            public string MyString { get; set; }
        }

        public void DoSomething()
        {
            int myval = 5 + 2;
        }
    }
}
