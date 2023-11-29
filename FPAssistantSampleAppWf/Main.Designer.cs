namespace FPAssistantSampleAppWf
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            GeneralToolStripMenuItem = new ToolStripMenuItem();
            conversionsToolStripMenuItem = new ToolStripMenuItem();
            airSpeedIndicatedToTrueToolStripMenuItem = new ToolStripMenuItem();
            iCAOToolStripMenuItem = new ToolStripMenuItem();
            BasicILSToolStripMenuItem = new ToolStripMenuItem();
            geodeticsToolStripMenuItem = new ToolStripMenuItem();
            geoCoordinateToolStripMenuItem = new ToolStripMenuItem();
            fAAToolStripMenuItem = new ToolStripMenuItem();
            distanceToolStripMenuItem = new ToolStripMenuItem();
            destinationToolStripMenuItem = new ToolStripMenuItem();
            greatCircleToolStripMenuItem = new ToolStripMenuItem();
            wGS84UTMToolStripMenuItem = new ToolStripMenuItem();
            intersectionToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            LinkLabelFpassistantSdkHome = new LinkLabel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { GeneralToolStripMenuItem, iCAOToolStripMenuItem, geodeticsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // GeneralToolStripMenuItem
            // 
            GeneralToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conversionsToolStripMenuItem, airSpeedIndicatedToTrueToolStripMenuItem });
            GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem";
            GeneralToolStripMenuItem.Size = new Size(46, 20);
            GeneralToolStripMenuItem.Text = "Tools";
            // 
            // conversionsToolStripMenuItem
            // 
            conversionsToolStripMenuItem.Name = "conversionsToolStripMenuItem";
            conversionsToolStripMenuItem.Size = new Size(223, 22);
            conversionsToolStripMenuItem.Text = "Conversions";
            conversionsToolStripMenuItem.Click += ConversionsToolStripMenuItem_Click;
            // 
            // airSpeedIndicatedToTrueToolStripMenuItem
            // 
            airSpeedIndicatedToTrueToolStripMenuItem.Name = "airSpeedIndicatedToTrueToolStripMenuItem";
            airSpeedIndicatedToTrueToolStripMenuItem.Size = new Size(223, 22);
            airSpeedIndicatedToTrueToolStripMenuItem.Text = "Air Speed (Indicated to True)";
            airSpeedIndicatedToTrueToolStripMenuItem.Click += AirSpeedIndicatedToTrueToolStripMenuItem_Click;
            // 
            // iCAOToolStripMenuItem
            // 
            iCAOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BasicILSToolStripMenuItem });
            iCAOToolStripMenuItem.Name = "iCAOToolStripMenuItem";
            iCAOToolStripMenuItem.Size = new Size(47, 20);
            iCAOToolStripMenuItem.Text = "ICAO";
            // 
            // BasicILSToolStripMenuItem
            // 
            BasicILSToolStripMenuItem.Name = "BasicILSToolStripMenuItem";
            BasicILSToolStripMenuItem.Size = new Size(119, 22);
            BasicILSToolStripMenuItem.Text = "Basic ILS";
            BasicILSToolStripMenuItem.Click += BasicILSToolStripMenuItem_Click;
            // 
            // geodeticsToolStripMenuItem
            // 
            geodeticsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { geoCoordinateToolStripMenuItem, fAAToolStripMenuItem, greatCircleToolStripMenuItem, wGS84UTMToolStripMenuItem, intersectionToolStripMenuItem });
            geodeticsToolStripMenuItem.Name = "geodeticsToolStripMenuItem";
            geodeticsToolStripMenuItem.Size = new Size(71, 20);
            geodeticsToolStripMenuItem.Text = "Geodetics";
            // 
            // geoCoordinateToolStripMenuItem
            // 
            geoCoordinateToolStripMenuItem.Name = "geoCoordinateToolStripMenuItem";
            geoCoordinateToolStripMenuItem.Size = new Size(168, 22);
            geoCoordinateToolStripMenuItem.Text = "GeoCoordinate";
            geoCoordinateToolStripMenuItem.Click += geoCoordinateToolStripMenuItem_Click;
            // 
            // fAAToolStripMenuItem
            // 
            fAAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { distanceToolStripMenuItem, destinationToolStripMenuItem });
            fAAToolStripMenuItem.Name = "fAAToolStripMenuItem";
            fAAToolStripMenuItem.Size = new Size(168, 22);
            fAAToolStripMenuItem.Text = "FAA";
            // 
            // distanceToolStripMenuItem
            // 
            distanceToolStripMenuItem.Name = "distanceToolStripMenuItem";
            distanceToolStripMenuItem.Size = new Size(134, 22);
            distanceToolStripMenuItem.Text = "Distance";
            distanceToolStripMenuItem.Click += distanceToolStripMenuItem_Click;
            // 
            // destinationToolStripMenuItem
            // 
            destinationToolStripMenuItem.Name = "destinationToolStripMenuItem";
            destinationToolStripMenuItem.Size = new Size(134, 22);
            destinationToolStripMenuItem.Text = "Destination";
            destinationToolStripMenuItem.Click += destinationToolStripMenuItem_Click;
            // 
            // greatCircleToolStripMenuItem
            // 
            greatCircleToolStripMenuItem.Name = "greatCircleToolStripMenuItem";
            greatCircleToolStripMenuItem.Size = new Size(168, 22);
            greatCircleToolStripMenuItem.Text = "Great Circle";
            // 
            // wGS84UTMToolStripMenuItem
            // 
            wGS84UTMToolStripMenuItem.Name = "wGS84UTMToolStripMenuItem";
            wGS84UTMToolStripMenuItem.Size = new Size(168, 22);
            wGS84UTMToolStripMenuItem.Text = "WGS-84 <-> UTM";
            // 
            // intersectionToolStripMenuItem
            // 
            intersectionToolStripMenuItem.Name = "intersectionToolStripMenuItem";
            intersectionToolStripMenuItem.Size = new Size(168, 22);
            intersectionToolStripMenuItem.Text = "Intersection";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(107, 22);
            AboutToolStripMenuItem.Text = "About";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // LinkLabelFpassistantSdkHome
            // 
            LinkLabelFpassistantSdkHome.AutoSize = true;
            LinkLabelFpassistantSdkHome.Font = new Font("Segoe UI", 12F);
            LinkLabelFpassistantSdkHome.Location = new Point(24, 46);
            LinkLabelFpassistantSdkHome.Name = "LinkLabelFpassistantSdkHome";
            LinkLabelFpassistantSdkHome.Size = new Size(217, 21);
            LinkLabelFpassistantSdkHome.TabIndex = 1;
            LinkLabelFpassistantSdkHome.TabStop = true;
            LinkLabelFpassistantSdkHome.Text = "FPAssistant Suite SDK website";
            LinkLabelFpassistantSdkHome.LinkClicked += LinkLabelFpassistantSdkHome_LinkClicked;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LinkLabelFpassistantSdkHome);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "FPAssistant SDK Sample App";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem GeneralToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem conversionsToolStripMenuItem;
        private ToolStripMenuItem iCAOToolStripMenuItem;
        private ToolStripMenuItem BasicILSToolStripMenuItem;
        private ToolStripMenuItem airSpeedIndicatedToTrueToolStripMenuItem;
        private ToolStripMenuItem geodeticsToolStripMenuItem;
        private ToolStripMenuItem fAAToolStripMenuItem;
        private ToolStripMenuItem distanceToolStripMenuItem;
        private ToolStripMenuItem destinationToolStripMenuItem;
        private ToolStripMenuItem greatCircleToolStripMenuItem;
        private ToolStripMenuItem wGS84UTMToolStripMenuItem;
        private ToolStripMenuItem intersectionToolStripMenuItem;
        private LinkLabel LinkLabelFpassistantSdkHome;
        private ToolStripMenuItem geoCoordinateToolStripMenuItem;
    }
}