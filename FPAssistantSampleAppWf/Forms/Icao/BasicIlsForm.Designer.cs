﻿namespace FPAssistantSampleAppWf.Forms.Icao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicIlsForm));
            SplitContainer = new SplitContainer();
            LabelLongitude = new Label();
            LabelLatitude = new Label();
            WebView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
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
            // LabelLongitude
            // 
            LabelLongitude.AutoSize = true;
            LabelLongitude.Location = new Point(12, 38);
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
    }
}