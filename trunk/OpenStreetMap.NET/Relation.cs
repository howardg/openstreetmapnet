using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OpenStreetMap
{
  [XmlRoot("relation")]
  [Serializable]
  public class Relation : OSMXML
  {
    [XmlAttribute]
    public int id;

    [XmlAttribute]
    public bool visible;

    [XmlAttribute]
    public string timestamp;

    [XmlAttribute]
    public string user;

    [XmlElement]
    public List<Member> member;

    public class Member
    {
      [XmlAttribute]
      public string type;

      [XmlAttribute("ref")]
      public string reference;

      [XmlAttribute]
      public string role;

      public Member() { }
      public Member(string p_type, string p_reference, string p_role) { type = p_type; reference = p_reference; role = p_role; }

    }

  }

  
}
