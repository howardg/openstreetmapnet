using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OpenStreetMap
{
  /// <summary>
  /// An OpenStreetMap way object. A way can represent an actual road, but also an area if it is closed. 
  /// A way consists of a number of references to nodes, and zero or more tags.
  /// Tags are key-value pairs that define the real world function of the way.
  /// </summary>
  [XmlRoot("way")]
  [Serializable]
  public class Way
  {
    /// <summary>
    /// The OpenStreetMap id, a unique integer identifier.
    /// </summary>
    [XmlAttribute]
    public int id;

    /// <summary>
    /// Summary to be written
    /// </summary>
    [XmlAttribute]
    public bool visible;

    /// <summary>
    /// The timestamp denotes the last modification to this way.
    /// </summary>
    [XmlAttribute]
    public string timestamp;

    /// <summary>
    /// The username of the user that last modified this way.
    /// </summary>
    [XmlAttribute]
    public string user;

    /// <summary>
    /// The nodes that make up this way. The order is of course important!
    /// </summary>
    [XmlElement("nd")]
    public List<NodeRef> nodes;

    /// <summary>
    /// The tags that give real world meaning to the way.
    /// See the Map_Features page on http://wiki.openstreetmap.org/ for a comprehensive overview of recommended tags.
    /// </summary>
    [XmlElement("tag")]
    public List<Tag> tags;
  }

  /// <summary>
  /// Holds a reference to an OpenStreetMap node.
  /// </summary>
  public class NodeRef
  {
    [XmlAttribute("ref")]
    public int node_reference;

    public NodeRef() { }

    public NodeRef(int ref_id)
    {
      node_reference = ref_id;
    }

    /// <summary>
    /// Gets a OpenStreetMap.Node pointer to the referenced node.
    /// </summary>
    /// <returns>an OpenStreetMap.Node</returns>
    public Node GetNode()
    {
      Node n = new Node();
      n.id = node_reference;
      // FIXME, implement lookup node in current OSMResponse object
      return n;
    }
  }

}
