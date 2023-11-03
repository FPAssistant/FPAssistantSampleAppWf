namespace FPAssistantSampleAppWf.Forms.General
{
    partial class AirSpeedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirSpeedForm));
            LabelIas = new Label();
            LabelAlitude = new Label();
            LabelIsa = new Label();
            LabelK = new Label();
            LabelTas = new Label();
            LabelTas10pc = new Label();
            TextBoxIas = new TextBox();
            TextBoxAltitude = new TextBox();
            TextBoxIsa = new TextBox();
            TextBoxK = new TextBox();
            TextBoxTas = new TextBox();
            TextBoxTas10pc = new TextBox();
            ToolTipAirSpeed = new ToolTip(components);
            ButtonClose = new Button();
            ComboBoxIasUnit = new ComboBox();
            ComboBoxAltitudeUnit = new ComboBox();
            LabelDegreesC = new Label();
            LinkLabelApiIndicatedAirSpeed = new LinkLabel();
            SuspendLayout();
            // 
            // LabelIas
            // 
            LabelIas.AutoSize = true;
            LabelIas.Location = new Point(12, 9);
            LabelIas.Name = "LabelIas";
            LabelIas.Size = new Size(24, 15);
            LabelIas.TabIndex = 0;
            LabelIas.Text = "IAS";
            ToolTipAirSpeed.SetToolTip(LabelIas, "Indicated Air Speed");
            // 
            // LabelAlitude
            // 
            LabelAlitude.AutoSize = true;
            LabelAlitude.Location = new Point(12, 39);
            LabelAlitude.Name = "LabelAlitude";
            LabelAlitude.Size = new Size(49, 15);
            LabelAlitude.TabIndex = 1;
            LabelAlitude.Text = "Altitude";
            ToolTipAirSpeed.SetToolTip(LabelAlitude, "Altitude of IAS to calculate");
            // 
            // LabelIsa
            // 
            LabelIsa.AutoSize = true;
            LabelIsa.Location = new Point(12, 68);
            LabelIsa.Name = "LabelIsa";
            LabelIsa.Size = new Size(24, 15);
            LabelIsa.TabIndex = 2;
            LabelIsa.Text = "ISA";
            // 
            // LabelK
            // 
            LabelK.AutoSize = true;
            LabelK.Location = new Point(279, 9);
            LabelK.Name = "LabelK";
            LabelK.Size = new Size(14, 15);
            LabelK.TabIndex = 3;
            LabelK.Text = "K";
            // 
            // LabelTas
            // 
            LabelTas.AutoSize = true;
            LabelTas.Location = new Point(279, 39);
            LabelTas.Name = "LabelTas";
            LabelTas.Size = new Size(26, 15);
            LabelTas.TabIndex = 4;
            LabelTas.Text = "TAS";
            // 
            // LabelTas10pc
            // 
            LabelTas10pc.AutoSize = true;
            LabelTas10pc.Location = new Point(279, 68);
            LabelTas10pc.Name = "LabelTas10pc";
            LabelTas10pc.Size = new Size(62, 15);
            LabelTas10pc.TabIndex = 5;
            LabelTas10pc.Text = "TAS + 10%";
            // 
            // TextBoxIas
            // 
            TextBoxIas.Location = new Point(70, 6);
            TextBoxIas.Name = "TextBoxIas";
            TextBoxIas.Size = new Size(66, 23);
            TextBoxIas.TabIndex = 6;
            TextBoxIas.Text = "250";
            ToolTipAirSpeed.SetToolTip(TextBoxIas, "Enter Indicated Air Speed");
            TextBoxIas.TextChanged += TextBox_TextChanged;
            // 
            // TextBoxAltitude
            // 
            TextBoxAltitude.Location = new Point(70, 36);
            TextBoxAltitude.Name = "TextBoxAltitude";
            TextBoxAltitude.Size = new Size(66, 23);
            TextBoxAltitude.TabIndex = 7;
            TextBoxAltitude.Text = "0";
            ToolTipAirSpeed.SetToolTip(TextBoxAltitude, "Enter Altitude");
            TextBoxAltitude.TextChanged += TextBox_TextChanged;
            // 
            // TextBoxIsa
            // 
            TextBoxIsa.Location = new Point(70, 65);
            TextBoxIsa.Name = "TextBoxIsa";
            TextBoxIsa.Size = new Size(66, 23);
            TextBoxIsa.TabIndex = 8;
            TextBoxIsa.Text = "15";
            ToolTipAirSpeed.SetToolTip(TextBoxIsa, "Enter ISA");
            TextBoxIsa.TextChanged += TextBox_TextChanged;
            // 
            // TextBoxK
            // 
            TextBoxK.Location = new Point(363, 6);
            TextBoxK.Name = "TextBoxK";
            TextBoxK.ReadOnly = true;
            TextBoxK.Size = new Size(77, 23);
            TextBoxK.TabIndex = 9;
            // 
            // TextBoxTas
            // 
            TextBoxTas.Location = new Point(363, 36);
            TextBoxTas.Name = "TextBoxTas";
            TextBoxTas.ReadOnly = true;
            TextBoxTas.Size = new Size(77, 23);
            TextBoxTas.TabIndex = 10;
            ToolTipAirSpeed.SetToolTip(TextBoxTas, "True Ait Speed");
            // 
            // TextBoxTas10pc
            // 
            TextBoxTas10pc.Location = new Point(363, 65);
            TextBoxTas10pc.Name = "TextBoxTas10pc";
            TextBoxTas10pc.ReadOnly = true;
            TextBoxTas10pc.Size = new Size(77, 23);
            TextBoxTas10pc.TabIndex = 11;
            ToolTipAirSpeed.SetToolTip(TextBoxTas10pc, "True Ait Speed + 10%");
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.Location = new Point(363, 128);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(77, 32);
            ButtonClose.TabIndex = 12;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // ComboBoxIasUnit
            // 
            ComboBoxIasUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIasUnit.FormattingEnabled = true;
            ComboBoxIasUnit.Location = new Point(142, 6);
            ComboBoxIasUnit.Name = "ComboBoxIasUnit";
            ComboBoxIasUnit.Size = new Size(81, 23);
            ComboBoxIasUnit.TabIndex = 13;
            ComboBoxIasUnit.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // ComboBoxAltitudeUnit
            // 
            ComboBoxAltitudeUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxAltitudeUnit.FormattingEnabled = true;
            ComboBoxAltitudeUnit.Location = new Point(142, 36);
            ComboBoxAltitudeUnit.Name = "ComboBoxAltitudeUnit";
            ComboBoxAltitudeUnit.Size = new Size(81, 23);
            ComboBoxAltitudeUnit.TabIndex = 14;
            ComboBoxAltitudeUnit.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // LabelDegreesC
            // 
            LabelDegreesC.AutoSize = true;
            LabelDegreesC.Location = new Point(142, 68);
            LabelDegreesC.Name = "LabelDegreesC";
            LabelDegreesC.Size = new Size(20, 15);
            LabelDegreesC.TabIndex = 15;
            LabelDegreesC.Text = "°C";
            // 
            // LinkLabelApiIndicatedAirSpeed
            // 
            LinkLabelApiIndicatedAirSpeed.AutoSize = true;
            LinkLabelApiIndicatedAirSpeed.Location = new Point(12, 145);
            LinkLabelApiIndicatedAirSpeed.Name = "LinkLabelApiIndicatedAirSpeed";
            LinkLabelApiIndicatedAirSpeed.Size = new Size(93, 15);
            LinkLabelApiIndicatedAirSpeed.TabIndex = 16;
            LinkLabelApiIndicatedAirSpeed.TabStop = true;
            LinkLabelApiIndicatedAirSpeed.Text = "FPAssistant : API";
            LinkLabelApiIndicatedAirSpeed.LinkClicked += LinkLabelApiIndicatedAirSpeed_LinkClicked;
            // 
            // AirSpeedForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 182);
            Controls.Add(LinkLabelApiIndicatedAirSpeed);
            Controls.Add(LabelDegreesC);
            Controls.Add(ComboBoxAltitudeUnit);
            Controls.Add(ComboBoxIasUnit);
            Controls.Add(ButtonClose);
            Controls.Add(TextBoxTas10pc);
            Controls.Add(TextBoxTas);
            Controls.Add(TextBoxK);
            Controls.Add(TextBoxIsa);
            Controls.Add(TextBoxAltitude);
            Controls.Add(TextBoxIas);
            Controls.Add(LabelTas10pc);
            Controls.Add(LabelTas);
            Controls.Add(LabelK);
            Controls.Add(LabelIsa);
            Controls.Add(LabelAlitude);
            Controls.Add(LabelIas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AirSpeedForm";
            Text = "Airspeed Form";
            Load += AirSpeedForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelIas;
        private Label LabelAlitude;
        private Label LabelIsa;
        private Label LabelK;
        private Label LabelTas;
        private Label LabelTas10pc;
        private TextBox TextBoxIas;
        private TextBox TextBoxAltitude;
        private TextBox TextBoxIsa;
        private TextBox TextBoxK;
        private TextBox TextBoxTas;
        private TextBox TextBoxTas10pc;
        private ToolTip ToolTipAirSpeed;
        private Button ButtonClose;
        private ComboBox ComboBoxIasUnit;
        private ComboBox ComboBoxAltitudeUnit;
        private Label LabelDegreesC;
        private LinkLabel LinkLabelApiIndicatedAirSpeed;
    }
}