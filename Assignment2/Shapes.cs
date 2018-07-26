using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
   
    class Shapes
    {
        double area;
        [MethodInfo(MethodName = "DisplayArea", ReturnType = "void", Parameters = "double value of radius", Message = "to calculate the area of circle")]
        public void DispalyArea(double a)
        {
            area = 3.14 * a * a;
            Console.WriteLine("Area :" + area);
            //Console.WriteLine(DateTime.Now.Month);
        }
        [MethodInfo(MethodName = "DisplayArea", ReturnType = "void", Parameters = "double value of length and breadth", Message = "to calculate the area of square and rectangle")]
        public void DispalyArea(double l, double b)
        {
            area = l * b;
            Console.WriteLine("Area :" + area);
        }
        [MethodInfo(MethodName = "DisplayArea", ReturnType = "void", Parameters = "double value of base and height", Message = "to calculate the area of triangle")]
        public void DispalyArea(double h, double b, double half)
        {
            area = half * b * h;
            Console.WriteLine("Area :" + area);
        }
    }
}
