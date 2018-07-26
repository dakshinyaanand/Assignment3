using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Assignment3
{
    class ReadWriteXml
    {
        List<Parts> plist = new List<Parts>();
        public ReadWriteXml()
        {
           
            plist.Add(new
                Parts
            {
                Item = "Motherboard",
                Manufacturer = "ASUS",
                Model = "P3B-F",
                Cost = 123.00
            });
            plist.Add(new
                 Parts
            {
                Item = "Video Card",
                Manufacturer = "ATI",
                Model = "All-in-Wonder Pro",
                Cost = 160.00
            });
            plist.Add(new
               Parts
            {
                Item = "Sound Card",
                Manufacturer = "Creative Labs",
                Model = "Blaster Live",
                Cost = 80.00
            });
            plist.Add(new
              Parts
            {
                Item = "inch Monitor",
                Manufacturer = "inch Monitor",
                Model = "995E",
                Cost = 290.00
            });
        }

        public void WriteXML()
        {
            XmlWriter w = XmlWriter.Create("c:\\files\\Parts.xml");
            w.WriteStartDocument();
            w.WriteStartElement("Parts");
            foreach (var v in plist)
            {
                w.WriteStartElement("Part");
               
                
                w.WriteElementString("Item", v.Item);
                w.WriteElementString("Manfacturer", v.Manufacturer);
                w.WriteElementString("Model", v.Model);
                w.WriteElementString("Cost", v.Cost.ToString());
                w.WriteEndElement();
            }
            w.WriteEndElement();
            w.WriteEndDocument();
            w.Close();
            Console.WriteLine("XML created");

        }

        public void readXml()
        {
            XElement xe = XElement.Load("c:\\files\\Parts.xml");
            var data = xe.Elements();
            foreach (var d in data)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("********************");

           
            var dat2 = from t in xe.Elements("Part")
                       where (int)t.Element("Cost") > 150
                       select t;
            foreach (var d in dat2)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("********************");
             foreach (var d in data)
            {
                Console.WriteLine(d.Element("Item").Value+" "+ d.Element("Cost").Value);
            }
        }

    }
}
