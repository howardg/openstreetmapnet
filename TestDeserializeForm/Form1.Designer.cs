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
      this.SuspendLayout();
      // 
      // OpenOSMXMLFileDialog
      // 
      this.OpenOSMXMLFileDialog.FileName = "OpenOSMXMLFileName";
      this.OpenOSMXMLFileDialog.Filter = "XML Files|*.xml|OSM XML Files|*.osm|All Files|*.*";
      this.OpenOSMXMLFileDialog.InitialDirectory = "C:\\";
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
      this.textBoxSelectedOSMXMLFile.ReadOnly = true;
      this.textBoxSelectedOSMXMLFile.Size = new System.Drawing.Size(543, 20);
      this.textBoxSelectedOSMXMLFile.TabIndex = 1;
      // 
      // XmlPreviewBrowserControl
      // 
      this.XmlPreviewBrowserControl.AllowNavigation = false;
      this.XmlPreviewBrowserControl.IsWebBrowserContextMenuEnabled = false;
      this.XmlPreviewBrowserControl.Location = new System.Drawing.Point(13, 43);
      this.XmlPreviewBrowserControl.MinimumSize = new System.Drawing.Size(20, 20);
      this.XmlPreviewBrowserControl.Name = "XmlPreviewBrowserControl";
      this.XmlPreviewBrowserControl.ScriptErrorsSuppressed = true;
      this.XmlPreviewBrowserControl.Size = new System.Drawing.Size(685, 320);
      this.XmlPreviewBrowserControl.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(710, 510);
      this.Controls.Add(this.XmlPreviewBrowserControl);
      this.Controls.Add(this.textBoxSelectedOSMXMLFile);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "OpenStreetMap.NET Deserializer test application";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog OpenOSMXMLFileDialog;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBoxSelectedOSMXMLFile;
    private System.Windows.Forms.WebBrowser XmlPreviewBrowserControl;
  }
}

