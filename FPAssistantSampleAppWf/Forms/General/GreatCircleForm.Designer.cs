﻿namespace FPAssistantSampleAppWf.Forms.General
{
    partial class GreatCircleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreatCircleForm));
            ButtonClose = new Button();
            LabelLatitude = new Label();
            LabelLongitude = new Label();
            LabelBearing = new Label();
            LabelDistance = new Label();
            TextBoxLatitude = new TextBox();
            TextBoxLongitude = new TextBox();
            TextBoxBearing = new TextBox();
            TextBoxDistance = new TextBox();
            TextBoxLatitudeResultFaa = new TextBox();
            TextBoxLongitudeResultFaa = new TextBox();
            LabelFaaCalc = new Label();
            TextBoxLatitudeResultCsMap = new TextBox();
            TextBoxLongitudeResultCsMap = new TextBox();
            LinkLabelApiFaa = new LinkLabel();
            LinkLabelApiCsMap = new LinkLabel();
            LabelCsMapCalc = new Label();
            SuspendLayout();
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.Location = new Point(373, 160);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(75, 23);
            ButtonClose.TabIndex = 0;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // LabelLatitude
            // 
            LabelLatitude.AutoSize = true;
            LabelLatitude.Location = new Point(12, 34);
            LabelLatitude.Name = "LabelLatitude";
            LabelLatitude.Size = new Size(50, 15);
            LabelLatitude.TabIndex = 1;
            LabelLatitude.Text = "Latitude";
            // 
            // LabelLongitude
            // 
            LabelLongitude.AutoSize = true;
            LabelLongitude.Location = new Point(12, 64);
            LabelLongitude.Name = "LabelLongitude";
            LabelLongitude.Size = new Size(61, 15);
            LabelLongitude.TabIndex = 2;
            LabelLongitude.Text = "Longitude";
            // 
            // LabelBearing
            // 
            LabelBearing.AutoSize = true;
            LabelBearing.Location = new Point(12, 96);
            LabelBearing.Name = "LabelBearing";
            LabelBearing.Size = new Size(47, 15);
            LabelBearing.TabIndex = 3;
            LabelBearing.Text = "Bearing";
            // 
            // LabelDistance
            // 
            LabelDistance.AutoSize = true;
            LabelDistance.Location = new Point(12, 129);
            LabelDistance.Name = "LabelDistance";
            LabelDistance.Size = new Size(74, 15);
            LabelDistance.TabIndex = 4;
            LabelDistance.Text = "Distance (m)";
            // 
            // TextBoxLatitude
            // 
            TextBoxLatitude.Location = new Point(102, 31);
            TextBoxLatitude.Name = "TextBoxLatitude";
            TextBoxLatitude.Size = new Size(100, 23);
            TextBoxLatitude.TabIndex = 5;
            TextBoxLatitude.TextChanged += TextBoxLatitude_TextChanged;
            // 
            // TextBoxLongitude
            // 
            TextBoxLongitude.Location = new Point(102, 61);
            TextBoxLongitude.Name = "TextBoxLongitude";
            TextBoxLongitude.Size = new Size(100, 23);
            TextBoxLongitude.TabIndex = 6;
            TextBoxLongitude.TextChanged += TextBoxLongitude_TextChanged;
            // 
            // TextBoxBearing
            // 
            TextBoxBearing.Location = new Point(102, 93);
            TextBoxBearing.Name = "TextBoxBearing";
            TextBoxBearing.Size = new Size(100, 23);
            TextBoxBearing.TabIndex = 7;
            TextBoxBearing.Text = "0";
            TextBoxBearing.TextChanged += TextBoxBearing_TextChanged;
            // 
            // TextBoxDistance
            // 
            TextBoxDistance.Location = new Point(102, 126);
            TextBoxDistance.Name = "TextBoxDistance";
            TextBoxDistance.Size = new Size(100, 23);
            TextBoxDistance.TabIndex = 8;
            TextBoxDistance.Text = "1000";
            TextBoxDistance.TextChanged += TextBoxDistance_TextChanged;
            // 
            // TextBoxLatitudeResultFaa
            // 
            TextBoxLatitudeResultFaa.Location = new Point(245, 31);
            TextBoxLatitudeResultFaa.Name = "TextBoxLatitudeResultFaa";
            TextBoxLatitudeResultFaa.ReadOnly = true;
            TextBoxLatitudeResultFaa.Size = new Size(100, 23);
            TextBoxLatitudeResultFaa.TabIndex = 9;
            // 
            // TextBoxLongitudeResultFaa
            // 
            TextBoxLongitudeResultFaa.Location = new Point(245, 61);
            TextBoxLongitudeResultFaa.Name = "TextBoxLongitudeResultFaa";
            TextBoxLongitudeResultFaa.ReadOnly = true;
            TextBoxLongitudeResultFaa.Size = new Size(100, 23);
            TextBoxLongitudeResultFaa.TabIndex = 10;
            // 
            // LabelFaaCalc
            // 
            LabelFaaCalc.AutoSize = true;
            LabelFaaCalc.Location = new Point(245, 9);
            LabelFaaCalc.Name = "LabelFaaCalc";
            LabelFaaCalc.Size = new Size(91, 15);
            LabelFaaCalc.TabIndex = 11;
            LabelFaaCalc.Text = "FAA Calculation";
            // 
            // TextBoxLatitudeResultCsMap
            // 
            TextBoxLatitudeResultCsMap.Location = new Point(351, 31);
            TextBoxLatitudeResultCsMap.Name = "TextBoxLatitudeResultCsMap";
            TextBoxLatitudeResultCsMap.ReadOnly = true;
            TextBoxLatitudeResultCsMap.Size = new Size(100, 23);
            TextBoxLatitudeResultCsMap.TabIndex = 12;
            // 
            // TextBoxLongitudeResultCsMap
            // 
            TextBoxLongitudeResultCsMap.Location = new Point(351, 61);
            TextBoxLongitudeResultCsMap.Name = "TextBoxLongitudeResultCsMap";
            TextBoxLongitudeResultCsMap.ReadOnly = true;
            TextBoxLongitudeResultCsMap.Size = new Size(100, 23);
            TextBoxLongitudeResultCsMap.TabIndex = 13;
            // 
            // LinkLabelApiFaa
            // 
            LinkLabelApiFaa.AutoSize = true;
            LinkLabelApiFaa.Location = new Point(12, 160);
            LinkLabelApiFaa.Name = "LinkLabelApiFaa";
            LinkLabelApiFaa.Size = new Size(115, 15);
            LinkLabelApiFaa.TabIndex = 14;
            LinkLabelApiFaa.TabStop = true;
            LinkLabelApiFaa.Text = "API: FAA Calculation";
            LinkLabelApiFaa.LinkClicked += LinkLabelApiFaa_LinkClicked;
            // 
            // LinkLabelApiCsMap
            // 
            LinkLabelApiCsMap.AutoSize = true;
            LinkLabelApiCsMap.Location = new Point(12, 179);
            LinkLabelApiCsMap.Name = "LinkLabelApiCsMap";
            LinkLabelApiCsMap.Size = new Size(139, 15);
            LinkLabelApiCsMap.TabIndex = 15;
            LinkLabelApiCsMap.TabStop = true;
            LinkLabelApiCsMap.Text = "API: CS-MAP Calculation";
            LinkLabelApiCsMap.LinkClicked += LinkLabelApiCsMap_LinkClicked;
            // 
            // LabelCsMapCalc
            // 
            LabelCsMapCalc.AutoSize = true;
            LabelCsMapCalc.Location = new Point(351, 9);
            LabelCsMapCalc.Name = "LabelCsMapCalc";
            LabelCsMapCalc.Size = new Size(115, 15);
            LabelCsMapCalc.TabIndex = 16;
            LabelCsMapCalc.Text = "CS-MAP Calculation";
            // 
            // GreatCircleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 203);
            Controls.Add(LabelCsMapCalc);
            Controls.Add(LinkLabelApiCsMap);
            Controls.Add(LinkLabelApiFaa);
            Controls.Add(TextBoxLongitudeResultCsMap);
            Controls.Add(TextBoxLatitudeResultCsMap);
            Controls.Add(LabelFaaCalc);
            Controls.Add(TextBoxLongitudeResultFaa);
            Controls.Add(TextBoxLatitudeResultFaa);
            Controls.Add(TextBoxDistance);
            Controls.Add(TextBoxBearing);
            Controls.Add(TextBoxLongitude);
            Controls.Add(TextBoxLatitude);
            Controls.Add(LabelDistance);
            Controls.Add(LabelBearing);
            Controls.Add(LabelLongitude);
            Controls.Add(LabelLatitude);
            Controls.Add(ButtonClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GreatCircleForm";
            Text = "Great Circle Geodetic Calculation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonClose;
        private Label LabelLatitude;
        private Label LabelLongitude;
        private Label LabelBearing;
        private Label LabelDistance;
        private TextBox TextBoxLatitude;
        private TextBox TextBoxLongitude;
        private TextBox TextBoxBearing;
        private TextBox TextBoxDistance;
        private TextBox TextBoxLatitudeResultFaa;
        private TextBox TextBoxLongitudeResultFaa;
        private Label LabelFaaCalc;
        private TextBox TextBoxLatitudeResultCsMap;
        private TextBox TextBoxLongitudeResultCsMap;
        private LinkLabel LinkLabelApiFaa;
        private LinkLabel LinkLabelApiCsMap;
        private Label LabelCsMapCalc;
    }
}