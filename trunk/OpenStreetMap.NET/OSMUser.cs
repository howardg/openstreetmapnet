using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenStreetMap.NET
{
  public class OSMUser
  {
    public string Username { get; set; }
    public string Password { get; set; }

    public bool isValid()
    {
      // FIXME check minimum user / pass length
      if (Username != null && Username.Length > 0 && Password != null && Password.Length > 0) return true;
      else return false;
    }
  }
}
