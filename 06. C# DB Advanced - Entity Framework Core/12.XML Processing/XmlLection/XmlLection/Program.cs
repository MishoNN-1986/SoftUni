using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XmlLection
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // защото разделителя в xml са '.' , а тук са ','

            XDocument doc = XDocument.Load("products.xml"); //зареждаме съдържание на файл в паметта на компютъра

            //doc.Root.Add(new XElement("product",
            //    new XAttribute("type", "medicine"),
            //    new XElement("name", "Analgin"),
            //    new XElement("price", 4.5M)));

            //doc.Save("custom.xml");

            //var products = doc.Root.Elements()
            //    .Where(p => decimal.Parse(p.Element("price").Value) > 1000);

            //Console.WriteLine(products.Count());

            //foreach (var product in products)
            //{
            //    string name = product.Element("name").Value;
            //    decimal price = decimal.Parse(product.Element("price").Value);

            //    Console.WriteLine($"{name}: {price}");

            //XmlSerializer serializer = new XmlSerializer(typeof(products));

            //using (FileStream stream = new FileStream("products.xml", FileMode.Open))
            //{
            //    var products = (products)serializer.Deserialize(stream);

            //    var filtered = products.product.Where(products => products.price > 1000);
            //}
        }
    }
}
