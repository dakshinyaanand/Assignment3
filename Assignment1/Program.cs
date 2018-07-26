using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaOrder> po = new List<PizzaOrder>
            {
                new PizzaOrder {OrderId=12,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='S',Topping="SweetCorn",Qty=2,price=525 },
                new PizzaOrder {OrderId=11,OrderDate=DateTime.Now,PizzaType="NonVeg",PizzaSize='M',Topping="Egg",Qty=5,price=725 },
                new PizzaOrder {OrderId=14,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='L',Topping="Onion",Qty=4,price=448 },
                new PizzaOrder {OrderId=13,OrderDate=DateTime.Now,PizzaType="NonVeg",PizzaSize='S',Topping="Chicken",Qty=3,price=978 },
                new PizzaOrder {OrderId=16,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='M',Topping="Capsicum",Qty=6,price=525 },
                new PizzaOrder {OrderId=20,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='S',Topping="Tomato",Qty=1,price=325 }
            };
            var data1 = from t in po
                       select t;
            foreach (var r in data1)
            {
                Console.WriteLine(r.OrderId + " " + r.OrderDate + " " + r.PizzaType + " " + r.PizzaSize + " " + r.Topping + " " + r.Qty + " " + r.price);
            }

            Console.WriteLine("******************");
            var data2 = from t in po
                        select new { Ptype=t.PizzaType, Psize = t.PizzaSize };
            foreach (var d in data2)
                Console.WriteLine(d.Ptype + " " + d.Psize);
            Console.WriteLine("******************");


            var data3 = from t in po
                        group t by t.PizzaType into grp
                        select new
                        {
                            Ptype = grp.Key,
                           
                            sumQTY = grp.Sum(x => x.Qty),
                            sumAmt=grp.Sum(y=>y.price)

                        };
            foreach (var t in data3)
            {
                Console.WriteLine(t.Ptype + "  " + t.sumQTY + "  " + "  " + t.sumAmt);

            }

            Console.WriteLine("******************");

            var data4 = from t in po
                        group t by t.PizzaSize into grp
                        select new
                        {
                            Ptype = grp.Key,

                            sumQTY = grp.Sum(x => x.Qty),
                            sumAmt = grp.Sum(y => y.price)

                        };
            foreach (var t in data4)
            {
                Console.WriteLine(t.Ptype + "  " + t.sumQTY + "  " + "  " + t.sumAmt);

            }

            Console.WriteLine("******************");

            var data5 = from x in po
                        where x.PizzaSize == 'M' || x.PizzaSize == 'm'
                        select new { Ptype = x.PizzaType, top = x.Topping };
            foreach (var h in data5)
            {
                Console.WriteLine(h.Ptype + " " + h.top);
            }
            Console.WriteLine("******************");

            var data6 = from x in po
                        where x.price == po.Max(y => y.price)
                        select x;
            foreach (var r in data6)
            {
                Console.WriteLine(r.OrderId + " " + r.OrderDate + " " + r.PizzaType + " " + r.PizzaSize + " " + r.Topping + " " + r.Qty + " " + r.price);
            }

            Console.WriteLine("******************");

            var data7 = from x in po
                        where x.price == po.Min(y => y.price)
                        select x;
            foreach (var r in data7)
            {
                Console.WriteLine(r.OrderId + " " + r.OrderDate + " " + r.PizzaType + " " + r.PizzaSize + " " + r.Topping + " " + r.Qty + " " + r.price);
            }
            Console.WriteLine("******************");





        }

    }
}
