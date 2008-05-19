using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OpenStreetMap
{
  [Serializable]
  [XmlRoot("osm")]
  public class OSMResponse
  {
    [XmlIgnore]
    private const string _apiversion = "0.5";

    [XmlIgnore]
    private const string _generator = "OpenStreetMap.NET";

    [XmlAttribute]
    public string version;

    [XmlAttribute]
    public string generator;

    [XmlElement]
    public List<Way> way = new List<Way>();

    [XmlElement]
    public List<Node> node = new List<Node>();

    [XmlElement]
    public List<Relation> relation = new List<Relation>();

    /// <summary>
    /// Default values for API version and generator will be used. 
    /// </summary>
    public OSMResponse()
    {
      version = _apiversion;
      generator = _generator;
    }

    /// <summary>
    /// Create an OSM Response object with custom version parameter
    /// </summary>
    /// <param name="APIVersion">The API version</param>
    public OSMResponse(string APIVersion)
    {
      version = APIVersion;
      generator = _apiversion;
    }

    /// <summary>
    /// Create an OSM Response object with custom version and generator parameters
    /// </summary>
    /// <param name="APIVersion">The API version</param>
    /// <param name="Generator">The generator string</param>
    public OSMResponse(string APIVersion, string Generator)
    {
      version = APIVersion;
      generator = Generator;
    }
}


}
