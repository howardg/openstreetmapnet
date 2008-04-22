using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace OpenStreetMap.NET
{
  /// <summary>
  /// TimeStamp exposes two methods to get an OSM timestamp value.
  /// 1. The parameterless Now() assumes the current local time 
  /// 2. The FromDateTime() takes a DateTime object. If the DateTimeKind is unspecified, Local time is assumed.
  /// </summary>
  public static class TimeStamp
  {
    // OSM timestamp format is "2006-03-14T10:07:23+00:00"
    private const string DateTimeString = "yyyy-mm-ddTHH:mm:ssK";

    public static string Now() { return DateTime.Now.ToString(DateTimeString); }

    public static string FromDateTime(DateTime _dt)
    {
      //IF THE DATETIME KIND IS UNSPECIFIED, ASSUME IT'S LOCAL TIME
      if (_dt.Kind == DateTimeKind.Unspecified) _dt = DateTime.SpecifyKind(_dt, DateTimeKind.Local);
      return _dt.ToString(DateTimeString);
    }
  }
}
