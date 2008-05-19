namespace TestDeserializeForm
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.OpenOSMXMLFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.button1 = new System.Windows.Forms.Button();
      this.textBoxSelectedOSMXMLFile = new System.Windows.Forms.TextBox();
      this.XmlPreviewBrowserControl = new System.Windows.Forms.WebBrowser();
      this.btnParse = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.treeParsedXML = new System.Windows.Forms.TreeView();
      this.listBoxSelectedObjectDetail = new System.Windows.Forms.ListBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // OpenOSMXMLFileDialog
      // 
      this.OpenOSMXMLFileDialog.FileName = "OpenOSMXMLFileName";
      this.OpenOSMXMLFileDialog.Filter = "XML Files|*.xml|OSM XML Files|*.osm|All Files|*.*";
      this.OpenOSMXMLFileDialog.InitialDirectory = "..\\..\\..\\OpenStreetMap.NET\\Examples\\";
      this.OpenOSMXMLFileDialog.Title = "Select an OSM XML file to process";
      this.OpenOSMXMLFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(13, 13);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(136, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Select OSM XML File...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBoxSelectedOSMXMLFile
      // 
      this.textBoxSelectedOSMXMLFile.Location = new System.Drawing.Point(155, 15);
      this.textBoxSelectedOSMXMLFile.Name = "textBoxSelectedOSMXMLFile";
      this.textBoxSelectedOSMXMLFile.Size = new System.Drawing.Size(462, 20);
      this.textBoxSelectedOSMXMLFile.TabIndex = 1;
      this.textBoxSelectedOSMXMLFile.TextChanged += new System.EventHandler(this.openFileDialog1_FileOk);
      // 
      // XmlPreviewBrowserControl
      // 
      this.XmlPreviewBrowserControl.AllowNavigation = false;
      this.XmlPreviewBrowserControl.IsWebBrowserContextMenuEnabled = false;
      this.XmlPreviewBrowserControl.Location = new System.Drawing.Point(6, 6);
      this.XmlPreviewBrowserControl.MinimumSize = new System.Drawing.Size(20, 20);
      this.XmlPreviewBrowserControl.Name = "XmlPreviewBrowserControl";
      this.XmlPreviewBrowserControl.ScriptErrorsSuppressed = true;
      this.XmlPreviewBrowserControl.Size = new System.Drawing.Size(665, 417);
      this.XmlPreviewBrowserControl.TabIndex = 2;
      // 
      // btnParse
      // 
      this.btnParse.Location = new System.Drawing.Point(623, 13);
      this.btnParse.Name = "btnParse";
      this.btnParse.Size = new System.Drawing.Size(75, 23);
      this.btnParse.TabIndex = 3;
      this.btnParse.Text = "Parse...";
      this.btnParse.UseVisualStyleBackColor = true;
      this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(13, 43);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(685, 455);
      this.tabControl1.TabIndex = 4;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.XmlPreviewBrowserControl);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(677, 429);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "XML";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.treeParsedXML);
      this.tabPage2.Controls.Add(this.listBoxSelectedObjectDetail);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(677, 429);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Parsed OSM Data";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // treeParsedXML
      // 
      this.treeParsedXML.Location = new System.Drawing.Point(4, 7);
      this.treeParsedXML.Name = "treeParsedXML";
      this.treeParsedXML.Size = new System.Drawing.Size(375, 416);
      this.treeParsedXML.TabIndex = 1;
      // 
      // listBoxSelectedObjectDetail
      // 
      this.listBoxSelectedObjectDetail.FormattingEnabled = true;
      this.listBoxSelectedObjectDetail.Location = new System.Drawing.Point(385, 6);
      this.listBoxSelectedObjectDetail.Name = "listBoxSelectedObjectDetail";
      this.listBoxSelectedObjectDetail.Size = new System.Drawing.Size(289, 420);
      this.listBoxSelectedObjectDetail.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(710, 510);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.btnParse);
      this.Controls.Add(this.textBoxSelectedOSMXMLFile);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "OpenStreetMap Deserializer test application";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog OpenOSMXMLFileDialog;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBoxSelectedOSMXMLFile;
    private System.Windows.Forms.WebBrowser XmlPreviewBrowserControl;
    private System.Windows.Forms.Button btnParse;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TreeView treeParsedXML;
    private System.Windows.Forms.ListBox listBoxSelectedObjectDetail;
  }
}

