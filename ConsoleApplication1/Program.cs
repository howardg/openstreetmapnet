using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenStreetMap.NET;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Net;

namespace TestSerializer
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("creating way xml...");
      TextWriter writer = new StreamWriter(@"c:\tmp\way.osm");
      XmlSerializer s = new XmlSerializer(typeof(Way));

      Way w = new Way();
      w.id = 19209;
      w.timestamp = TimeStamp.Now();
      w.visible = true;
      w.user = "mvexel";

      List<Tag> tags = new List<Tag>();
      tags.Add(new Tag("highway", "primary"));

      w.tags = tags;

      List<NodeRef> noderefs = new List<NodeRef>();
      noderefs.Add(new NodeRef(1223984));
      noderefs.Add(new NodeRef(12987321));

      w.nodes = noderefs;

      //The TimeStamp takes a datetime object as well
      w.timestamp = TimeStamp.FromDateTime(new DateTime(2007, 7, 1, 14, 0, 0));

      s.Serialize(writer, w);

      Console.WriteLine("creating relation xml...");
      writer = new StreamWriter(@"c:\tmp\relation.osm");
      s = new XmlSerializer(typeof(Relation));

      Relation r = new Relation();
      r.id = 12345;

      List<Relation.Member> members = new List<Relation.Member>();
      members.Add(new Relation.Member("way", "1234", "begin"));
      members.Add(new Relation.Member("node", "2345", "numbers"));
      members.Add(new Relation.Member("way", "3456", "end"));
      r.member = members;
      r.timestamp = TimeStamp.Now();
      r.user = "mvexel";
      r.visible = true;

      s.Serialize(writer, r);


    }
  }
}
