using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OpenStreetMap
{
  [Serializable]
  public class OSMResponse : OSMXML
  {
    [XmlArray]
    public List<Way> Ways = new List<Way>();

    [XmlArray]
    public List<Node> Nodes = new List<Node>();

    [XmlArray]
    public List<Relation> Relations = new List<Relation>();
  }

  
}
