namespace FPAssistantSampleAppWf.Forms.General
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
            TextBoxLatitudeResult = new TextBox();
            TextBoxLongitudeResult = new TextBox();
            SuspendLayout();
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.Location = new Point(320, 141);
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
            // 
            // TextBoxLongitude
            // 
            TextBoxLongitude.Location = new Point(102, 61);
            TextBoxLongitude.Name = "TextBoxLongitude";
            TextBoxLongitude.Size = new Size(100, 23);
            TextBoxLongitude.TabIndex = 6;
            // 
            // TextBoxBearing
            // 
            TextBoxBearing.Location = new Point(102, 93);
            TextBoxBearing.Name = "TextBoxBearing";
            TextBoxBearing.Size = new Size(100, 23);
            TextBoxBearing.TabIndex = 7;
            TextBoxBearing.Text = "0";
            // 
            // TextBoxDistance
            // 
            TextBoxDistance.Location = new Point(102, 126);
            TextBoxDistance.Name = "TextBoxDistance";
            TextBoxDistance.Size = new Size(100, 23);
            TextBoxDistance.TabIndex = 8;
            TextBoxDistance.Text = "1000";
            // 
            // TextBoxLatitudeResult
            // 
            TextBoxLatitudeResult.Location = new Point(245, 31);
            TextBoxLatitudeResult.Name = "TextBoxLatitudeResult";
            TextBoxLatitudeResult.ReadOnly = true;
            TextBoxLatitudeResult.Size = new Size(100, 23);
            TextBoxLatitudeResult.TabIndex = 9;
            // 
            // TextBoxLongitudeResult
            // 
            TextBoxLongitudeResult.Location = new Point(245, 61);
            TextBoxLongitudeResult.Name = "TextBoxLongitudeResult";
            TextBoxLongitudeResult.ReadOnly = true;
            TextBoxLongitudeResult.Size = new Size(100, 23);
            TextBoxLongitudeResult.TabIndex = 10;
            // 
            // GreatCircleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 184);
            Controls.Add(TextBoxLongitudeResult);
            Controls.Add(TextBoxLatitudeResult);
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
        private TextBox TextBoxLatitudeResult;
        private TextBox TextBoxLongitudeResult;
    }
}