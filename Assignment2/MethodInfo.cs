using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    [AttributeUsage(AttributeTargets.Method)]
    class MethodInfo:Attribute
    {
        public string MethodName { get; set; }
        public string ReturnType { get; set; }
        public string Parameters { get; set; }
        public string Message { get; set; }

    }
}
