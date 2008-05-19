using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TestDeserializeForm
{
  public partial class Form1 : Form
  {
    private string OSMXMLFilename = "";

    public Form1()
    {
      InitializeComponent();
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      OSMXMLFilename = (sender as FileDialog).FileName;
      textBoxSelectedOSMXMLFile.Text = OSMXMLFilename;
      XmlDocument OSMXMLDoc = new XmlDocument();
      OSMXMLDoc.Load(new FileStream(OSMXMLFilename, FileMode.Open));
      textBoxSelectedOSMXMLFile.Text = OSMXMLFilename;
      XmlPreviewBrowserControl.Navigate(OSMXMLFilename);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OpenOSMXMLFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
      OpenOSMXMLFileDialog.ShowDialog();
    }

    private void btnParse_Click(object sender, EventArgs e)
    {
      XmlSerializer ser = new XmlSerializer(typeof(OpenStreetMap.OSMResponse));
      OpenStreetMap.OSMResponse response = (OpenStreetMap.OSMResponse)ser.Deserialize(new StringReader(textBoxSelectedOSMXMLFile.Text));
    }
  }
}
