namespace FPAssistantSampleAppWf.Forms.Faa
{
    partial class FaaDestinationForm
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
            LabelLatitude = new Label();
            LabelLongitude = new Label();
            TextBoxLatitude = new TextBox();
            TextBoxLongitude = new TextBox();
            LabelStartCoordinate = new Label();
            LabelDestinationCoordinate = new Label();
            TextBoxDestinationLatitude = new TextBox();
            TextBoxDestinationLongitude = new TextBox();
            LabelDistance = new Label();
            TextBoxDistance = new TextBox();
            LabelBearing = new Label();
            TextBoxBearing = new TextBox();
            ButtonClose = new Button();
            LinkLabelWGS84Destination = new LinkLabel();
            SuspendLayout();
            // 
            // LabelLatitude
            // 
            LabelLatitude.AutoSize = true;
            LabelLatitude.Location = new Point(12, 39);
            LabelLatitude.Name = "LabelLatitude";
            LabelLatitude.Size = new Size(50, 15);
            LabelLatitude.TabIndex = 0;
            LabelLatitude.Text = "Latitude";
            // 
            // LabelLongitude
            // 
            LabelLongitude.AutoSize = true;
            LabelLongitude.Location = new Point(12, 68);
            LabelLongitude.Name = "LabelLongitude";
            LabelLongitude.Size = new Size(61, 15);
            LabelLongitude.TabIndex = 1;
            LabelLongitude.Text = "Longitude";
            // 
            // TextBoxLatitude
            // 
            TextBoxLatitude.Location = new Point(101, 36);
            TextBoxLatitude.Name = "TextBoxLatitude";
            TextBoxLatitude.Size = new Size(100, 23);
            TextBoxLatitude.TabIndex = 2;
            TextBoxLatitude.Text = "51.1481018100";
            TextBoxLatitude.TextChanged += TextBoxLatitude_TextChanged;
            // 
            // TextBoxLongitude
            // 
            TextBoxLongitude.Location = new Point(101, 65);
            TextBoxLongitude.Name = "TextBoxLongitude";
            TextBoxLongitude.Size = new Size(100, 23);
            TextBoxLongitude.TabIndex = 3;
            TextBoxLongitude.Text = "-000.1902779940";
            TextBoxLongitude.TextChanged += TextBoxLongitude_TextChanged;
            // 
            // LabelStartCoordinate
            // 
            LabelStartCoordinate.AutoSize = true;
            LabelStartCoordinate.Location = new Point(101, 9);
            LabelStartCoordinate.Name = "LabelStartCoordinate";
            LabelStartCoordinate.Size = new Size(93, 15);
            LabelStartCoordinate.TabIndex = 4;
            LabelStartCoordinate.Text = "Start Coordinate";
            // 
            // LabelDestinationCoordinate
            // 
            LabelDestinationCoordinate.AutoSize = true;
            LabelDestinationCoordinate.Location = new Point(247, 9);
            LabelDestinationCoordinate.Name = "LabelDestinationCoordinate";
            LabelDestinationCoordinate.Size = new Size(129, 15);
            LabelDestinationCoordinate.TabIndex = 5;
            LabelDestinationCoordinate.Text = "Destination Coordinate";
            // 
            // TextBoxDestinationLatitude
            // 
            TextBoxDestinationLatitude.Location = new Point(247, 36);
            TextBoxDestinationLatitude.Name = "TextBoxDestinationLatitude";
            TextBoxDestinationLatitude.ReadOnly = true;
            TextBoxDestinationLatitude.Size = new Size(100, 23);
            TextBoxDestinationLatitude.TabIndex = 6;
            // 
            // TextBoxDestinationLongitude
            // 
            TextBoxDestinationLongitude.Location = new Point(247, 65);
            TextBoxDestinationLongitude.Name = "TextBoxDestinationLongitude";
            TextBoxDestinationLongitude.ReadOnly = true;
            TextBoxDestinationLongitude.Size = new Size(100, 23);
            TextBoxDestinationLongitude.TabIndex = 7;
            // 
            // LabelDistance
            // 
            LabelDistance.AutoSize = true;
            LabelDistance.Location = new Point(12, 97);
            LabelDistance.Name = "LabelDistance";
            LabelDistance.Size = new Size(74, 15);
            LabelDistance.TabIndex = 8;
            LabelDistance.Text = "Distance (m)";
            // 
            // TextBoxDistance
            // 
            TextBoxDistance.Location = new Point(101, 94);
            TextBoxDistance.Name = "TextBoxDistance";
            TextBoxDistance.Size = new Size(100, 23);
            TextBoxDistance.TabIndex = 9;
            TextBoxDistance.Text = "10000";
            TextBoxDistance.TextChanged += TextBoxDistance_TextChanged;
            // 
            // LabelBearing
            // 
            LabelBearing.AutoSize = true;
            LabelBearing.Location = new Point(12, 129);
            LabelBearing.Name = "LabelBearing";
            LabelBearing.Size = new Size(47, 15);
            LabelBearing.TabIndex = 10;
            LabelBearing.Text = "Bearing";
            // 
            // TextBoxBearing
            // 
            TextBoxBearing.Location = new Point(101, 126);
            TextBoxBearing.Name = "TextBoxBearing";
            TextBoxBearing.Size = new Size(100, 23);
            TextBoxBearing.TabIndex = 11;
            TextBoxBearing.Text = "000";
            TextBoxBearing.TextChanged += TextBoxBearing_TextChanged;
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.Location = new Point(362, 178);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(75, 23);
            ButtonClose.TabIndex = 12;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // LinkLabelWGS84Destination
            // 
            LinkLabelWGS84Destination.AutoSize = true;
            LinkLabelWGS84Destination.Location = new Point(12, 182);
            LinkLabelWGS84Destination.Name = "LinkLabelWGS84Destination";
            LinkLabelWGS84Destination.Size = new Size(136, 15);
            LinkLabelWGS84Destination.TabIndex = 13;
            LinkLabelWGS84Destination.TabStop = true;
            LinkLabelWGS84Destination.Text = "API: WGS84Destination()";
            LinkLabelWGS84Destination.LinkClicked += LinkLabelWGS84Destination_LinkClicked;
            // 
            // FaaDestinationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 213);
            Controls.Add(LinkLabelWGS84Destination);
            Controls.Add(ButtonClose);
            Controls.Add(TextBoxBearing);
            Controls.Add(LabelBearing);
            Controls.Add(TextBoxDistance);
            Controls.Add(LabelDistance);
            Controls.Add(TextBoxDestinationLongitude);
            Controls.Add(TextBoxDestinationLatitude);
            Controls.Add(LabelDestinationCoordinate);
            Controls.Add(LabelStartCoordinate);
            Controls.Add(TextBoxLongitude);
            Controls.Add(TextBoxLatitude);
            Controls.Add(LabelLongitude);
            Controls.Add(LabelLatitude);
            Name = "FaaDestinationForm";
            Text = "Destination from Coordinate, Distance and Bearing (FAA)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelLatitude;
        private Label LabelLongitude;
        private TextBox TextBoxLatitude;
        private TextBox TextBoxLongitude;
        private Label LabelStartCoordinate;
        private Label LabelDestinationCoordinate;
        private TextBox TextBoxDestinationLatitude;
        private TextBox TextBoxDestinationLongitude;
        private Label LabelDistance;
        private TextBox TextBoxDistance;
        private Label LabelBearing;
        private TextBox TextBoxBearing;
        private Button ButtonClose;
        private LinkLabel LinkLabelWGS84Destination;
    }
}