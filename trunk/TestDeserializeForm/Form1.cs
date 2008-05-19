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
    private XmlDocument OSMXMLDoc;

    public Form1()
    {
      InitializeComponent();
      btnParse.Enabled = false;
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      OSMXMLFilename = (sender as FileDialog).FileName;
      textBoxSelectedOSMXMLFile.Text = OSMXMLFilename;
      OSMXMLDoc = new XmlDocument();
      OSMXMLDoc.Load(new FileStream(OSMXMLFilename, FileMode.Open));
      textBoxSelectedOSMXMLFile.Text = OSMXMLFilename;
      XmlPreviewBrowserControl.Navigate(OSMXMLFilename);
      btnParse.Enabled = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OpenOSMXMLFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
      OpenOSMXMLFileDialog.ShowDialog();
    }

    private void btnParse_Click(object sender, EventArgs e)
    {
      XmlSerializer ser = new XmlSerializer(typeof(OpenStreetMap.OSMResponse));
      OpenStreetMap.OSMResponse response = (OpenStreetMap.OSMResponse)ser.Deserialize(new StringReader(OSMXMLDoc.InnerXml));
      // POPULATE THE TREEVIEW
      treeParsedXML.Nodes.Clear();
      treeParsedXML.Nodes.Add(new TreeNode(OSMXMLDoc.DocumentElement.Name));
      TreeNode t = new TreeNode();
      t = treeParsedXML.Nodes[0];
      AddNode(OSMXMLDoc.DocumentElement, t);

      treeParsedXML.ExpandAll();

      // SWITH TO THE TREEVIEW
    }

    private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
    {
      XmlNode xNode;
      TreeNode tNode;
      XmlNodeList nodeList;
      int i;

      // Loop through the XML nodes until the leaf is reached.
      // Add the nodes to the TreeView during the looping process.
      if (inXmlNode.HasChildNodes)
      {
        nodeList = inXmlNode.ChildNodes;
        for (i = 0; i <= nodeList.Count - 1; i++)
        {
          xNode = inXmlNode.ChildNodes[i];
          inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
          tNode = inTreeNode.Nodes[i];
          AddNode(xNode, tNode);
        }
      }
      else
      {
        // Here you need to pull the data from the XmlNode based on the
        // type of node, whether attribute values are required, and so forth.
        inTreeNode.Nodes.Add(new TreeNode(inXmlNode.Name));
      }
    }

    private void openFileDialog1_FileOk(object sender, EventArgs e)
    {

    }

  }
}
