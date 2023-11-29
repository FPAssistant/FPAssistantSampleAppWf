namespace FPAssistantSampleAppWf.Forms.General
{
    partial class GeoCoordinateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoCoordinateForm));
            ButtonClose = new Button();
            LabelLatitude = new Label();
            LabelLongitude = new Label();
            LabelDecimalDms = new Label();
            TextBoxLatitudeDecimalDms = new TextBox();
            TextBoxLongitudeDecimalDms = new TextBox();
            LabelLatitudeDegrees = new Label();
            TextBoxLatitudeDegrees = new TextBox();
            TextBoxLongitudeDegrees = new TextBox();
            TextBoxLatitudeMinutes = new TextBox();
            TextBoxLongitudeMinutes = new TextBox();
            LabelMinutes = new Label();
            TextBoxLatitudeSeconds = new TextBox();
            TextBoxLongitudeSeconds = new TextBox();
            LabelSeconds = new Label();
            LabelCardinal = new Label();
            ComboBoxLatitudeCardinal = new ComboBox();
            ComboBoxLongitudeCardinal = new ComboBox();
            LinkLabelApiGeoCoordinate = new LinkLabel();
            SuspendLayout();
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.Location = new Point(458, 257);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(98, 40);
            ButtonClose.TabIndex = 0;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // LabelLatitude
            // 
            LabelLatitude.AutoSize = true;
            LabelLatitude.Location = new Point(112, 9);
            LabelLatitude.Name = "LabelLatitude";
            LabelLatitude.Size = new Size(50, 15);
            LabelLatitude.TabIndex = 1;
            LabelLatitude.Text = "Latitude";
            // 
            // LabelLongitude
            // 
            LabelLongitude.AutoSize = true;
            LabelLongitude.Location = new Point(225, 9);
            LabelLongitude.Name = "LabelLongitude";
            LabelLongitude.Size = new Size(61, 15);
            LabelLongitude.TabIndex = 2;
            LabelLongitude.Text = "Longitude";
            // 
            // LabelDecimalDms
            // 
            LabelDecimalDms.AutoSize = true;
            LabelDecimalDms.Location = new Point(12, 38);
            LabelDecimalDms.Name = "LabelDecimalDms";
            LabelDecimalDms.Size = new Size(78, 15);
            LabelDecimalDms.TabIndex = 3;
            LabelDecimalDms.Text = "Decimal DMS";
            // 
            // TextBoxLatitudeDecimalDms
            // 
            TextBoxLatitudeDecimalDms.Location = new Point(112, 35);
            TextBoxLatitudeDecimalDms.Name = "TextBoxLatitudeDecimalDms";
            TextBoxLatitudeDecimalDms.Size = new Size(100, 23);
            TextBoxLatitudeDecimalDms.TabIndex = 4;
            TextBoxLatitudeDecimalDms.TextChanged += TextBoxLatitudeDecimalDms_TextChanged;
            // 
            // TextBoxLongitudeDecimalDms
            // 
            TextBoxLongitudeDecimalDms.Location = new Point(225, 35);
            TextBoxLongitudeDecimalDms.Name = "TextBoxLongitudeDecimalDms";
            TextBoxLongitudeDecimalDms.Size = new Size(100, 23);
            TextBoxLongitudeDecimalDms.TabIndex = 5;
            TextBoxLongitudeDecimalDms.TextChanged += TextBoxLongitudeDecimalDms_TextChanged;
            // 
            // LabelLatitudeDegrees
            // 
            LabelLatitudeDegrees.AutoSize = true;
            LabelLatitudeDegrees.Location = new Point(12, 76);
            LabelLatitudeDegrees.Name = "LabelLatitudeDegrees";
            LabelLatitudeDegrees.Size = new Size(49, 15);
            LabelLatitudeDegrees.TabIndex = 6;
            LabelLatitudeDegrees.Text = "Degrees";
            // 
            // TextBoxLatitudeDegrees
            // 
            TextBoxLatitudeDegrees.Location = new Point(112, 73);
            TextBoxLatitudeDegrees.Name = "TextBoxLatitudeDegrees";
            TextBoxLatitudeDegrees.Size = new Size(100, 23);
            TextBoxLatitudeDegrees.TabIndex = 7;
            TextBoxLatitudeDegrees.TextChanged += TextBoxLatitudeDegrees_TextChanged;
            // 
            // TextBoxLongitudeDegrees
            // 
            TextBoxLongitudeDegrees.Location = new Point(225, 73);
            TextBoxLongitudeDegrees.Name = "TextBoxLongitudeDegrees";
            TextBoxLongitudeDegrees.Size = new Size(100, 23);
            TextBoxLongitudeDegrees.TabIndex = 8;
            TextBoxLongitudeDegrees.TextChanged += TextBoxLongitudeDegrees_TextChanged;
            // 
            // TextBoxLatitudeMinutes
            // 
            TextBoxLatitudeMinutes.Location = new Point(112, 112);
            TextBoxLatitudeMinutes.Name = "TextBoxLatitudeMinutes";
            TextBoxLatitudeMinutes.Size = new Size(100, 23);
            TextBoxLatitudeMinutes.TabIndex = 9;
            TextBoxLatitudeMinutes.TextChanged += TextBoxLatitudeMinutes_TextChanged;
            // 
            // TextBoxLongitudeMinutes
            // 
            TextBoxLongitudeMinutes.Location = new Point(225, 112);
            TextBoxLongitudeMinutes.Name = "TextBoxLongitudeMinutes";
            TextBoxLongitudeMinutes.Size = new Size(100, 23);
            TextBoxLongitudeMinutes.TabIndex = 10;
            TextBoxLongitudeMinutes.TextChanged += TextBoxLongitudeMinutes_TextChanged;
            // 
            // LabelMinutes
            // 
            LabelMinutes.AutoSize = true;
            LabelMinutes.Location = new Point(12, 115);
            LabelMinutes.Name = "LabelMinutes";
            LabelMinutes.Size = new Size(50, 15);
            LabelMinutes.TabIndex = 11;
            LabelMinutes.Text = "Minutes";
            // 
            // TextBoxLatitudeSeconds
            // 
            TextBoxLatitudeSeconds.Location = new Point(112, 152);
            TextBoxLatitudeSeconds.Name = "TextBoxLatitudeSeconds";
            TextBoxLatitudeSeconds.Size = new Size(100, 23);
            TextBoxLatitudeSeconds.TabIndex = 12;
            TextBoxLatitudeSeconds.Text = "0.0";
            TextBoxLatitudeSeconds.TextChanged += TextBoxLatitudeSeconds_TextChanged;
            // 
            // TextBoxLongitudeSeconds
            // 
            TextBoxLongitudeSeconds.Location = new Point(225, 152);
            TextBoxLongitudeSeconds.Name = "TextBoxLongitudeSeconds";
            TextBoxLongitudeSeconds.Size = new Size(100, 23);
            TextBoxLongitudeSeconds.TabIndex = 13;
            TextBoxLongitudeSeconds.Text = "0.0";
            TextBoxLongitudeSeconds.TextChanged += TextBoxLongitudeSeconds_TextChanged;
            // 
            // LabelSeconds
            // 
            LabelSeconds.AutoSize = true;
            LabelSeconds.Location = new Point(12, 155);
            LabelSeconds.Name = "LabelSeconds";
            LabelSeconds.Size = new Size(51, 15);
            LabelSeconds.TabIndex = 14;
            LabelSeconds.Text = "Seconds";
            // 
            // LabelCardinal
            // 
            LabelCardinal.AutoSize = true;
            LabelCardinal.Location = new Point(12, 198);
            LabelCardinal.Name = "LabelCardinal";
            LabelCardinal.Size = new Size(51, 15);
            LabelCardinal.TabIndex = 15;
            LabelCardinal.Text = "Cardinal";
            // 
            // ComboBoxLatitudeCardinal
            // 
            ComboBoxLatitudeCardinal.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxLatitudeCardinal.FormattingEnabled = true;
            ComboBoxLatitudeCardinal.Items.AddRange(new object[] { "N", "S" });
            ComboBoxLatitudeCardinal.Location = new Point(112, 195);
            ComboBoxLatitudeCardinal.Name = "ComboBoxLatitudeCardinal";
            ComboBoxLatitudeCardinal.Size = new Size(100, 23);
            ComboBoxLatitudeCardinal.TabIndex = 18;
            ComboBoxLatitudeCardinal.SelectedValueChanged += ComboBoxLatitudeCardinal_SelectedValueChanged;
            // 
            // ComboBoxLongitudeCardinal
            // 
            ComboBoxLongitudeCardinal.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxLongitudeCardinal.FormattingEnabled = true;
            ComboBoxLongitudeCardinal.Items.AddRange(new object[] { "E", "W" });
            ComboBoxLongitudeCardinal.Location = new Point(225, 195);
            ComboBoxLongitudeCardinal.Name = "ComboBoxLongitudeCardinal";
            ComboBoxLongitudeCardinal.Size = new Size(100, 23);
            ComboBoxLongitudeCardinal.TabIndex = 19;
            ComboBoxLongitudeCardinal.SelectedValueChanged += ComboBoxLongitudeCardinal_SelectedValueChanged;
            // 
            // LinkLabelApiGeoCoordinate
            // 
            LinkLabelApiGeoCoordinate.AutoSize = true;
            LinkLabelApiGeoCoordinate.Location = new Point(12, 282);
            LinkLabelApiGeoCoordinate.Name = "LinkLabelApiGeoCoordinate";
            LinkLabelApiGeoCoordinate.Size = new Size(111, 15);
            LinkLabelApiGeoCoordinate.TabIndex = 20;
            LinkLabelApiGeoCoordinate.TabStop = true;
            LinkLabelApiGeoCoordinate.Text = "API: GeoCoordinate";
            LinkLabelApiGeoCoordinate.LinkClicked += LinkLabelApiGeoCoordinate_LinkClicked;
            // 
            // GeoCoordinateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 309);
            Controls.Add(LinkLabelApiGeoCoordinate);
            Controls.Add(ComboBoxLongitudeCardinal);
            Controls.Add(ComboBoxLatitudeCardinal);
            Controls.Add(LabelCardinal);
            Controls.Add(LabelSeconds);
            Controls.Add(TextBoxLongitudeSeconds);
            Controls.Add(TextBoxLatitudeSeconds);
            Controls.Add(LabelMinutes);
            Controls.Add(TextBoxLongitudeMinutes);
            Controls.Add(TextBoxLatitudeMinutes);
            Controls.Add(TextBoxLongitudeDegrees);
            Controls.Add(TextBoxLatitudeDegrees);
            Controls.Add(LabelLatitudeDegrees);
            Controls.Add(TextBoxLongitudeDecimalDms);
            Controls.Add(TextBoxLatitudeDecimalDms);
            Controls.Add(LabelDecimalDms);
            Controls.Add(LabelLongitude);
            Controls.Add(LabelLatitude);
            Controls.Add(ButtonClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GeoCoordinateForm";
            Text = "GeoCoordinate API Features";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonClose;
        private Label LabelLatitude;
        private Label LabelLongitude;
        private Label LabelDecimalDms;
        private TextBox TextBoxLatitudeDecimalDms;
        private TextBox TextBoxLongitudeDecimalDms;
        private Label LabelLatitudeDegrees;
        private TextBox TextBoxLatitudeDegrees;
        private TextBox TextBoxLongitudeDegrees;
        private TextBox TextBoxLatitudeMinutes;
        private TextBox TextBoxLongitudeMinutes;
        private Label LabelMinutes;
        private TextBox TextBoxLatitudeSeconds;
        private TextBox TextBoxLongitudeSeconds;
        private Label LabelSeconds;
        private Label LabelCardinal;
        private ComboBox ComboBoxLatitudeCardinal;
        private ComboBox ComboBoxLongitudeCardinal;
        private LinkLabel LinkLabelApiGeoCoordinate;
    }
}