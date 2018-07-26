using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            double a, b, c;
            Shapes s = new Shapes();
            Console.WriteLine("A.square\nB.rectangle\nC.triangle\nD.circle\nenter your choice:");
            ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'A':
                    {
                        Console.WriteLine("enter the side value:");
                        a = double.Parse(Console.ReadLine());
                        s.DispalyArea(a, a);
                        break;
                    }
                case 'B':
                    {
                        Console.WriteLine("enter the length and brd:");
                        a = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                        s.DispalyArea(a, b);
                        break;

                    }
                case 'C':
                    {
                        Console.WriteLine("enter the base and height value:");
                        a = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                        c = 0.5;
                        s.DispalyArea(a, b, c);
                        break;

                    }
                case 'D':
                    {
                        Console.WriteLine("enter the radius value:");
                        a = double.Parse(Console.ReadLine());

                        s.DispalyArea(a);
                        break;

                    }




            }
        }
    }
}
