namespace FPAssistantSampleAppWf.Forms.Icao
{
    partial class BasicIlsForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicIlsForm));
            SplitContainer = new SplitContainer();
            ButtonSaveToGml = new Button();
            TextBoxElevation = new TextBox();
            LabelElevation = new Label();
            TextBoxBearing = new TextBox();
            LabelBearing = new Label();
            TextBoxLongitude = new TextBox();
            TextBoxLatitude = new TextBox();
            ButtonConstruct = new Button();
            LabelLongitude = new Label();
            LabelLatitude = new Label();
            WebView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ToolTipBasicIlsForm = new ToolTip(components);
            LabelMetres = new Label();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WebView21).BeginInit();
            SuspendLayout();
            // 
            // SplitContainer
            // 
            SplitContainer.Dock = DockStyle.Fill;
            SplitContainer.Location = new Point(0, 0);
            SplitContainer.Name = "SplitContainer";
            SplitContainer.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(LabelMetres);
            SplitContainer.Panel1.Controls.Add(ButtonSaveToGml);
            SplitContainer.Panel1.Controls.Add(TextBoxElevation);
            SplitContainer.Panel1.Controls.Add(LabelElevation);
            SplitContainer.Panel1.Controls.Add(TextBoxBearing);
            SplitContainer.Panel1.Controls.Add(LabelBearing);
            SplitContainer.Panel1.Controls.Add(TextBoxLongitude);
            SplitContainer.Panel1.Controls.Add(TextBoxLatitude);
            SplitContainer.Panel1.Controls.Add(ButtonConstruct);
            SplitContainer.Panel1.Controls.Add(LabelLongitude);
            SplitContainer.Panel1.Controls.Add(LabelLatitude);
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(WebView21);
            SplitContainer.Size = new Size(984, 461);
            SplitContainer.SplitterDistance = 78;
            SplitContainer.TabIndex = 0;
            // 
            // ButtonSaveToGml
            // 
            ButtonSaveToGml.Location = new Point(895, 7);
            ButtonSaveToGml.Name = "ButtonSaveToGml";
            ButtonSaveToGml.Size = new Size(75, 23);
            ButtonSaveToGml.TabIndex = 9;
            ButtonSaveToGml.Text = "GML->";
            ButtonSaveToGml.UseVisualStyleBackColor = true;
            ButtonSaveToGml.Click += ButtonSaveToGml_Click;
            // 
            // TextBoxElevation
            // 
            TextBoxElevation.Location = new Point(268, 39);
            TextBoxElevation.Name = "TextBoxElevation";
            TextBoxElevation.Size = new Size(100, 23);
            TextBoxElevation.TabIndex = 8;
            TextBoxElevation.Text = "0.0";
            ToolTipBasicIlsForm.SetToolTip(TextBoxElevation, "Elevation in Metres (m)");
            // 
            // LabelElevation
            // 
            LabelElevation.AutoSize = true;
            LabelElevation.Location = new Point(207, 42);
            LabelElevation.Name = "LabelElevation";
            LabelElevation.Size = new Size(55, 15);
            LabelElevation.TabIndex = 7;
            LabelElevation.Text = "Elevation";
            // 
            // TextBoxBearing
            // 
            TextBoxBearing.Location = new Point(268, 6);
            TextBoxBearing.Name = "TextBoxBearing";
            TextBoxBearing.Size = new Size(100, 23);
            TextBoxBearing.TabIndex = 6;
            TextBoxBearing.Text = "0";
            ToolTipBasicIlsForm.SetToolTip(TextBoxBearing, "Bearing in Degrees");
            // 
            // LabelBearing
            // 
            LabelBearing.AutoSize = true;
            LabelBearing.Location = new Point(207, 9);
            LabelBearing.Name = "LabelBearing";
            LabelBearing.Size = new Size(47, 15);
            LabelBearing.TabIndex = 5;
            LabelBearing.Text = "Bearing";
            // 
            // TextBoxLongitude
            // 
            TextBoxLongitude.Location = new Point(79, 35);
            TextBoxLongitude.Name = "TextBoxLongitude";
            TextBoxLongitude.Size = new Size(100, 23);
            TextBoxLongitude.TabIndex = 4;
            ToolTipBasicIlsForm.SetToolTip(TextBoxLongitude, "Longitude in Decimal");
            // 
            // TextBoxLatitude
            // 
            TextBoxLatitude.Location = new Point(79, 6);
            TextBoxLatitude.Name = "TextBoxLatitude";
            TextBoxLatitude.Size = new Size(100, 23);
            TextBoxLatitude.TabIndex = 3;
            ToolTipBasicIlsForm.SetToolTip(TextBoxLatitude, "Latitude in Decimal");
            // 
            // ButtonConstruct
            // 
            ButtonConstruct.Location = new Point(897, 38);
            ButtonConstruct.Name = "ButtonConstruct";
            ButtonConstruct.Size = new Size(75, 23);
            ButtonConstruct.TabIndex = 2;
            ButtonConstruct.Text = "Construct";
            ButtonConstruct.UseVisualStyleBackColor = true;
            ButtonConstruct.Click += ButtonConstruct_Click;
            // 
            // LabelLongitude
            // 
            LabelLongitude.AutoSize = true;
            LabelLongitude.Location = new Point(12, 42);
            LabelLongitude.Name = "LabelLongitude";
            LabelLongitude.Size = new Size(61, 15);
            LabelLongitude.TabIndex = 1;
            LabelLongitude.Text = "Longitude";
            // 
            // LabelLatitude
            // 
            LabelLatitude.AutoSize = true;
            LabelLatitude.Location = new Point(12, 9);
            LabelLatitude.Name = "LabelLatitude";
            LabelLatitude.Size = new Size(50, 15);
            LabelLatitude.TabIndex = 0;
            LabelLatitude.Text = "Latitude";
            // 
            // WebView21
            // 
            WebView21.AllowExternalDrop = true;
            WebView21.CreationProperties = null;
            WebView21.DefaultBackgroundColor = Color.White;
            WebView21.Dock = DockStyle.Fill;
            WebView21.Location = new Point(0, 0);
            WebView21.Name = "WebView21";
            WebView21.Size = new Size(984, 379);
            WebView21.Source = new Uri("https://www.microsoft.com", UriKind.Absolute);
            WebView21.TabIndex = 0;
            WebView21.ZoomFactor = 1D;
            // 
            // LabelMetres
            // 
            LabelMetres.AutoSize = true;
            LabelMetres.Location = new Point(374, 42);
            LabelMetres.Name = "LabelMetres";
            LabelMetres.Size = new Size(43, 15);
            LabelMetres.TabIndex = 10;
            LabelMetres.Text = "Metres";
            // 
            // BasicIlsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(SplitContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BasicIlsForm";
            Text = "ICAO Basic ILS Construction";
            Load += BasicIlsForm_Load;
            Resize += BasicIlsForm_Resize;
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel1.PerformLayout();
            SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WebView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer SplitContainer;
        private Label LabelLatitude;
        private Label LabelLongitude;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView21;
        private Button ButtonConstruct;
        private TextBox TextBoxBearing;
        private Label LabelBearing;
        private TextBox TextBoxLongitude;
        private TextBox TextBoxLatitude;
        private Label LabelElevation;
        private Button ButtonSaveToGml;
        private TextBox TextBoxElevation;
        private ToolTip ToolTipBasicIlsForm;
        private Label LabelMetres;
    }
}