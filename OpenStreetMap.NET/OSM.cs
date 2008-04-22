using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OpenStreetMap.NET
{
  [XmlRoot("osm")]
  public abstract partial class OSMXML
  {
    [XmlAttribute]
    public string version;

    [XmlAttribute]
    public string generator;
  }


  /// <summary>
  /// The type of request to be made
  /// </summary>
  public enum RequestTypes {
    /// <summary>
    /// Create a new object. Supply a Node, Way or Relation to the OSMRequest instance.
    /// This operation modifies the database. OSM server credentials must be passed as an OSMUser object.
    /// </summary>
    Creation,
    /// <summary>
    /// Retrieve one object. Supply an ID and the desired ObjectType to the request object.
    /// </summary>
    Retrieval, 
    /// <summary>
    /// Update one object. Supply a Node, Way or Relation to the OSMRequest instance.
    /// This operation modifies the database. OSM server credentials must be passed as an OSMUser object.
    /// </summary>
    Update, 
    /// <summary>
    /// Delete one object. Supply a Node, Way or Relation to the OSMRequest instance.
    /// This operation modifies the database. OSM server credentials must be passed as an OSMUser object.
    /// </summary>
    Deletion, 
    /// <summary>
    /// Retrieve all objects within a bounding box. Supply a BoundingBox to the OSMRequest instance
    /// </summary>
    BBoxOSMXML,
    /// <summary>
    /// Retrieve raw GPS track points within a bounding box. Supply a BoundingBox to the OSMRequest instance.
    /// This is not implemented yet.
    /// </summary>
    BBoxGPXTrackpoints
  }

  public enum ObjectTypes
  {
    Node,
    Way,
    Relation
  }


}
