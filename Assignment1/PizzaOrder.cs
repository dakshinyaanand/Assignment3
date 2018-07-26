using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class PizzaOrder
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string PizzaType { get; set; }
        public char PizzaSize { get; set; }
        public string Topping { get; set; }
        public int Qty { get; set; }
        public double price { get; set; }
    }
}
