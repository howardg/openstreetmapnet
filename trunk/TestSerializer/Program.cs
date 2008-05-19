using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenStreetMap;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace TestSerializer
{
  class Program
  {
    static void Main(string[] args)
    {
      Node n = new Node();
      n.lat = 52.50;
      n.lon = 5.50;
      n.id = 129834;
      n.timestamp = TimeStamp.Now();
      XmlSerializer s = new XmlSerializer(typeof(Node));
      Stream writer = new FileStream("c:\\tmp\\out.xml",FileMode.Create);
      s.Serialize(writer,n);
      Console.ReadKey();
    }
  }
}
