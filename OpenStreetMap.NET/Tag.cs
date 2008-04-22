using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OpenStreetMap.NET
{
  /// <summary>
  /// Represents a tag. Multiple tags are allowed for both Ways and Nodes.
  /// </summary>
  public class Tag
  {
    [XmlAttribute]
    public string k;
    [XmlAttribute]
    public string v;

    public Tag() { }
    public Tag(string key, string value)
    { k = key; v = value; }
  }
}
