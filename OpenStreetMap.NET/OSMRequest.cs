using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenStreetMap
{
  public class OSMRequest : OSMXML
  {
    internal RequestTypes RequestType { get; set; }
    internal BoundingBox BBox { get; set; }
    internal OSMUser User { get; set; }
    internal Node Node { get; set; }
    internal Way Way { get; set; }
    internal Relation Relation { get; set; }
    internal ObjectTypes ObjectType { get; set; }
    internal int OSMID { get; set; }

    public OSMRequest()
    {
      OSMID = 0;
    }
    public OSMRequest(RequestTypes reqtype)
    {
      OSMID = 0;
      RequestType = reqtype;
    }

    /// <summary>
    /// Initialize an OSMRequest instance to request OSM XML data for a bounding box
    /// </summary>
    /// <param name="bbox"></param>
    public OSMRequest(BoundingBox bbox)
    {
      RequestType = RequestTypes.BBoxOSMXML;
      BBox = bbox;
    }

    /// <summary>
    /// Check if the combination of parameters supplied would yield a valid request.
    /// </summary>
    /// <returns>true or false</returns>
    private bool IsValid()
    {
      //FIXME not implemented.
      //CHECK for validity of request
      // If RequestType is Creation, a valid Node, Way or Relation, and an OSMUser should be passed.
      // If RequestType is Retrieval, an ID and and an ObjectType should be passed.
      // If RequestType is Update, a valid Node, Way or Relation, and an OSMUser should be passed.
      // If RequestType is Deletion, an ID, an ObjectType and an OSMUser should be passed.
      // If RequestType is one of the BBox types, a valid BBox of acceptable size should be passed.
      switch (RequestType)
      {
        case RequestTypes.Creation:
          if (!User.isValid()) return false;
          if (ObjectType == ObjectTypes.Node && this.Node != null) return true;
          if (ObjectType == ObjectTypes.Relation && this.Relation != null) return true;
          if (ObjectType == ObjectTypes.Way && this.Way != null) return true;
          break;
        case RequestTypes.Retrieval:
          if (ObjectType != null && OSMID > 0) return true;
          break;
        case RequestTypes.Update:
          // FIXME implement
          if (!User.isValid()) return false;
          return true;
          break;
        case RequestTypes.Deletion:
          // FIXME implement
          if (!User.isValid()) return false;
          return true;
          break;
        case RequestTypes.BBoxOSMXML:
        case RequestTypes.BBoxGPXTrackpoints:
          // FIXME implement
          return true;
          break;
        default:
          return false;
          break;
      }
      return false;
    }

    public OSMResponse Fire()
    {
      //DO THE REQUEST
      // FIXME implement
      return new OSMResponse();
    }

  }
}
