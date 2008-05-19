using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OpenStreetMap
{
  [XmlRoot("node")]
  [Serializable]
  public class Node
  {
    [XmlAttribute("id")]
    public int id;
    [XmlAttribute("lat")]
    public double lat;
    [XmlAttribute("lon")]
    public double lon;
    [XmlAttribute("visible")]
    public bool visible;
    [XmlAttribute("timestamp")]
    public string timestamp;
  }
}
