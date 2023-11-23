namespace FPAssistantSampleAppWf.Forms.Faa
{
    partial class FaaDistanceForm
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
            LabelLatitude1 = new Label();
            LabelLongitude1 = new Label();
            TextBoxLatitude1 = new TextBox();
            TextBoxLongitude1 = new TextBox();
            TextBoxLatitude2 = new TextBox();
            TextBoxLongitude2 = new TextBox();
            LabelDistance = new Label();
            TextBoxDistanceMetres = new TextBox();
            TextBoxDistanceKm = new TextBox();
            TextBoxDistanceNm = new TextBox();
            TextBoxDistanceFeet = new TextBox();
            TextBoxAzimuthForward = new TextBox();
            TextBoxAzimuthReverse = new TextBox();
            LabelAzimuthForward = new Label();
            LabelAzimuthReverse = new Label();
            LabelMetres = new Label();
            LabelKilometres = new Label();
            LabelNauticalMiles = new Label();
            LabelFeet = new Label();
            ButtonClose = new Button();
            LinkLabelFaaDistance = new LinkLabel();
            SuspendLayout();
            // 
            // LabelLatitude1
            // 
            LabelLatitude1.AutoSize = true;
            LabelLatitude1.Location = new Point(12, 17);
            LabelLatitude1.Name = "LabelLatitude1";
            LabelLatitude1.Size = new Size(50, 15);
            LabelLatitude1.TabIndex = 0;
            LabelLatitude1.Text = "Latitude";
            // 
            // LabelLongitude1
            // 
            LabelLongitude1.AutoSize = true;
            LabelLongitude1.Location = new Point(12, 49);
            LabelLongitude1.Name = "LabelLongitude1";
            LabelLongitude1.Size = new Size(61, 15);
            LabelLongitude1.TabIndex = 1;
            LabelLongitude1.Text = "Longitude";
            // 
            // TextBoxLatitude1
            // 
            TextBoxLatitude1.Location = new Point(109, 14);
            TextBoxLatitude1.Name = "TextBoxLatitude1";
            TextBoxLatitude1.Size = new Size(100, 23);
            TextBoxLatitude1.TabIndex = 2;
            TextBoxLatitude1.Text = "51.1481018100";
            TextBoxLatitude1.TextChanged += TextBoxLatitude1_TextChanged;
            // 
            // TextBoxLongitude1
            // 
            TextBoxLongitude1.Location = new Point(109, 46);
            TextBoxLongitude1.Name = "TextBoxLongitude1";
            TextBoxLongitude1.Size = new Size(100, 23);
            TextBoxLongitude1.TabIndex = 3;
            TextBoxLongitude1.Text = "-0.1902779940";
            TextBoxLongitude1.TextChanged += TextBoxLongitude1_TextChanged;
            // 
            // TextBoxLatitude2
            // 
            TextBoxLatitude2.Location = new Point(229, 14);
            TextBoxLatitude2.Name = "TextBoxLatitude2";
            TextBoxLatitude2.Size = new Size(100, 23);
            TextBoxLatitude2.TabIndex = 4;
            TextBoxLatitude2.Text = "51.4706000000";
            TextBoxLatitude2.TextChanged += TextBoxLatitude2_TextChanged;
            // 
            // TextBoxLongitude2
            // 
            TextBoxLongitude2.Location = new Point(229, 46);
            TextBoxLongitude2.Name = "TextBoxLongitude2";
            TextBoxLongitude2.Size = new Size(100, 23);
            TextBoxLongitude2.TabIndex = 5;
            TextBoxLongitude2.Text = "-0.4619410000";
            TextBoxLongitude2.TextChanged += TextBoxLongitude2_TextChanged;
            // 
            // LabelDistance
            // 
            LabelDistance.AutoSize = true;
            LabelDistance.Location = new Point(373, 17);
            LabelDistance.Name = "LabelDistance";
            LabelDistance.Size = new Size(52, 15);
            LabelDistance.TabIndex = 6;
            LabelDistance.Text = "Distance";
            // 
            // TextBoxDistanceMetres
            // 
            TextBoxDistanceMetres.Location = new Point(373, 35);
            TextBoxDistanceMetres.Name = "TextBoxDistanceMetres";
            TextBoxDistanceMetres.ReadOnly = true;
            TextBoxDistanceMetres.Size = new Size(100, 23);
            TextBoxDistanceMetres.TabIndex = 7;
            // 
            // TextBoxDistanceKm
            // 
            TextBoxDistanceKm.Location = new Point(373, 64);
            TextBoxDistanceKm.Name = "TextBoxDistanceKm";
            TextBoxDistanceKm.ReadOnly = true;
            TextBoxDistanceKm.Size = new Size(100, 23);
            TextBoxDistanceKm.TabIndex = 8;
            // 
            // TextBoxDistanceNm
            // 
            TextBoxDistanceNm.Location = new Point(373, 93);
            TextBoxDistanceNm.Name = "TextBoxDistanceNm";
            TextBoxDistanceNm.ReadOnly = true;
            TextBoxDistanceNm.Size = new Size(100, 23);
            TextBoxDistanceNm.TabIndex = 9;
            // 
            // TextBoxDistanceFeet
            // 
            TextBoxDistanceFeet.Location = new Point(373, 122);
            TextBoxDistanceFeet.Name = "TextBoxDistanceFeet";
            TextBoxDistanceFeet.ReadOnly = true;
            TextBoxDistanceFeet.Size = new Size(100, 23);
            TextBoxDistanceFeet.TabIndex = 10;
            // 
            // TextBoxAzimuthForward
            // 
            TextBoxAzimuthForward.Location = new Point(229, 93);
            TextBoxAzimuthForward.Name = "TextBoxAzimuthForward";
            TextBoxAzimuthForward.ReadOnly = true;
            TextBoxAzimuthForward.Size = new Size(100, 23);
            TextBoxAzimuthForward.TabIndex = 11;
            // 
            // TextBoxAzimuthReverse
            // 
            TextBoxAzimuthReverse.Location = new Point(229, 122);
            TextBoxAzimuthReverse.Name = "TextBoxAzimuthReverse";
            TextBoxAzimuthReverse.ReadOnly = true;
            TextBoxAzimuthReverse.Size = new Size(100, 23);
            TextBoxAzimuthReverse.TabIndex = 12;
            // 
            // LabelAzimuthForward
            // 
            LabelAzimuthForward.AutoSize = true;
            LabelAzimuthForward.Location = new Point(109, 96);
            LabelAzimuthForward.Name = "LabelAzimuthForward";
            LabelAzimuthForward.Size = new Size(98, 15);
            LabelAzimuthForward.TabIndex = 13;
            LabelAzimuthForward.Text = "Forward Azimuth";
            // 
            // LabelAzimuthReverse
            // 
            LabelAzimuthReverse.AutoSize = true;
            LabelAzimuthReverse.Location = new Point(109, 125);
            LabelAzimuthReverse.Name = "LabelAzimuthReverse";
            LabelAzimuthReverse.Size = new Size(95, 15);
            LabelAzimuthReverse.TabIndex = 14;
            LabelAzimuthReverse.Text = "Reverse Azimuth";
            // 
            // LabelMetres
            // 
            LabelMetres.AutoSize = true;
            LabelMetres.Location = new Point(479, 38);
            LabelMetres.Name = "LabelMetres";
            LabelMetres.Size = new Size(18, 15);
            LabelMetres.TabIndex = 15;
            LabelMetres.Text = "m";
            // 
            // LabelKilometres
            // 
            LabelKilometres.AutoSize = true;
            LabelKilometres.Location = new Point(479, 67);
            LabelKilometres.Name = "LabelKilometres";
            LabelKilometres.Size = new Size(24, 15);
            LabelKilometres.TabIndex = 16;
            LabelKilometres.Text = "km";
            // 
            // LabelNauticalMiles
            // 
            LabelNauticalMiles.AutoSize = true;
            LabelNauticalMiles.Location = new Point(479, 96);
            LabelNauticalMiles.Name = "LabelNauticalMiles";
            LabelNauticalMiles.Size = new Size(27, 15);
            LabelNauticalMiles.TabIndex = 17;
            LabelNauticalMiles.Text = "NM";
            // 
            // LabelFeet
            // 
            LabelFeet.AutoSize = true;
            LabelFeet.Location = new Point(479, 125);
            LabelFeet.Name = "LabelFeet";
            LabelFeet.Size = new Size(15, 15);
            LabelFeet.TabIndex = 18;
            LabelFeet.Text = "ft";
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.Location = new Point(519, 217);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(82, 27);
            ButtonClose.TabIndex = 19;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // LinkLabelFaaDistance
            // 
            LinkLabelFaaDistance.AutoSize = true;
            LinkLabelFaaDistance.Location = new Point(12, 168);
            LinkLabelFaaDistance.Name = "LinkLabelFaaDistance";
            LinkLabelFaaDistance.Size = new Size(100, 15);
            LinkLabelFaaDistance.TabIndex = 20;
            LinkLabelFaaDistance.TabStop = true;
            LinkLabelFaaDistance.Text = "API: FAA Distance";
            LinkLabelFaaDistance.Click += LinkLabelFaaDistance_Click;
            // 
            // FaaDistanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 272);
            Controls.Add(LinkLabelFaaDistance);
            Controls.Add(ButtonClose);
            Controls.Add(LabelFeet);
            Controls.Add(LabelNauticalMiles);
            Controls.Add(LabelKilometres);
            Controls.Add(LabelMetres);
            Controls.Add(LabelAzimuthReverse);
            Controls.Add(LabelAzimuthForward);
            Controls.Add(TextBoxAzimuthReverse);
            Controls.Add(TextBoxAzimuthForward);
            Controls.Add(TextBoxDistanceFeet);
            Controls.Add(TextBoxDistanceNm);
            Controls.Add(TextBoxDistanceKm);
            Controls.Add(TextBoxDistanceMetres);
            Controls.Add(LabelDistance);
            Controls.Add(TextBoxLongitude2);
            Controls.Add(TextBoxLatitude2);
            Controls.Add(TextBoxLongitude1);
            Controls.Add(TextBoxLatitude1);
            Controls.Add(LabelLongitude1);
            Controls.Add(LabelLatitude1);
            Name = "FaaDistanceForm";
            Text = "Distance between two coordinates (FAA)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelLatitude1;
        private Label LabelLongitude1;
        private TextBox TextBoxLatitude1;
        private TextBox TextBoxLongitude1;
        private TextBox TextBoxLatitude2;
        private TextBox TextBoxLongitude2;
        private Label LabelDistance;
        private TextBox TextBoxDistanceMetres;
        private TextBox TextBoxDistanceKm;
        private TextBox TextBoxDistanceNm;
        private TextBox TextBoxDistanceFeet;
        private TextBox TextBoxAzimuthForward;
        private TextBox TextBoxAzimuthReverse;
        private Label LabelAzimuthForward;
        private Label LabelAzimuthReverse;
        private Label LabelMetres;
        private Label LabelKilometres;
        private Label LabelNauticalMiles;
        private Label LabelFeet;
        private Button ButtonClose;
        private LinkLabel LinkLabelFaaDistance;
    }
}