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
      XmlSerializer s = new XmlSerializer(typeof(OSMResponse));
      Stream writer = new FileStream("c:\\tmp\\out.xml",FileMode.Create);

      OSMResponse resp = new OSMResponse();
      resp.version = "0.5";
      resp.generator = "OpenStreetMap.NET";


      Node n = new Node();
      n.lat = 52.50;
      n.lon = 5.50;
      n.id = 129834;
      n.timestamp = TimeStamp.Now();

      resp.node.Add(n);

      n = new Node();
      n.lat = 55.50;
      n.lon = 4.50;
      n.id = 1294324234;
      n.timestamp = TimeStamp.Now();

      resp.node.Add(n);

      s.Serialize(writer,resp);
      Console.ReadKey();
    }
  }
}
