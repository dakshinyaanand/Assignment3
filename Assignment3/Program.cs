﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWriteXml xml = new ReadWriteXml();
            //xml.WriteXML();
            xml.readXml();
        }
    }
}
