namespace FPAssistantSampleAppWf.Forms.General
{
    partial class ConversionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionsForm));
            ButtonClose = new Button();
            LabelNm = new Label();
            LabelKm = new Label();
            TextBoxNm = new TextBox();
            TextBoxKm = new TextBox();
            LabelFeet = new Label();
            LabelMetres = new Label();
            TextBoxFeet = new TextBox();
            TextBoxMetres = new TextBox();
            SuspendLayout();
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.Location = new Point(274, 105);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(83, 34);
            ButtonClose.TabIndex = 0;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // LabelNm
            // 
            LabelNm.AutoSize = true;
            LabelNm.Location = new Point(19, 15);
            LabelNm.Name = "LabelNm";
            LabelNm.Size = new Size(27, 15);
            LabelNm.TabIndex = 1;
            LabelNm.Text = "NM";
            // 
            // LabelKm
            // 
            LabelKm.AutoSize = true;
            LabelKm.Location = new Point(21, 62);
            LabelKm.Name = "LabelKm";
            LabelKm.Size = new Size(25, 15);
            LabelKm.TabIndex = 2;
            LabelKm.Text = "KM";
            // 
            // TextBoxNm
            // 
            TextBoxNm.Location = new Point(67, 12);
            TextBoxNm.Name = "TextBoxNm";
            TextBoxNm.Size = new Size(100, 23);
            TextBoxNm.TabIndex = 3;
            TextBoxNm.Text = "1";
            TextBoxNm.TextChanged += TextBoxNm_TextChanged;
            // 
            // TextBoxKm
            // 
            TextBoxKm.Location = new Point(67, 59);
            TextBoxKm.Name = "TextBoxKm";
            TextBoxKm.Size = new Size(100, 23);
            TextBoxKm.TabIndex = 4;
            TextBoxKm.TextChanged += TextBoxKm_TextChanged;
            // 
            // LabelFeet
            // 
            LabelFeet.AutoSize = true;
            LabelFeet.Location = new Point(203, 20);
            LabelFeet.Name = "LabelFeet";
            LabelFeet.Size = new Size(29, 15);
            LabelFeet.TabIndex = 5;
            LabelFeet.Text = "Feet";
            // 
            // LabelMetres
            // 
            LabelMetres.AutoSize = true;
            LabelMetres.Location = new Point(203, 67);
            LabelMetres.Name = "LabelMetres";
            LabelMetres.Size = new Size(43, 15);
            LabelMetres.TabIndex = 6;
            LabelMetres.Text = "Metres";
            // 
            // TextBoxFeet
            // 
            TextBoxFeet.Location = new Point(252, 12);
            TextBoxFeet.Name = "TextBoxFeet";
            TextBoxFeet.Size = new Size(105, 23);
            TextBoxFeet.TabIndex = 7;
            TextBoxFeet.TextChanged += TextBoxFeet_TextChanged;
            // 
            // TextBoxMetres
            // 
            TextBoxMetres.Location = new Point(252, 59);
            TextBoxMetres.Name = "TextBoxMetres";
            TextBoxMetres.Size = new Size(105, 23);
            TextBoxMetres.TabIndex = 8;
            TextBoxMetres.TextChanged += TextBoxMetres_TextChanged;
            // 
            // ConversionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 167);
            Controls.Add(TextBoxMetres);
            Controls.Add(TextBoxFeet);
            Controls.Add(LabelMetres);
            Controls.Add(LabelFeet);
            Controls.Add(TextBoxKm);
            Controls.Add(TextBoxNm);
            Controls.Add(LabelKm);
            Controls.Add(LabelNm);
            Controls.Add(ButtonClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConversionsForm";
            Text = "Linear Distance Conversions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonClose;
        private Label LabelNm;
        private Label LabelKm;
        private TextBox TextBoxNm;
        private TextBox TextBoxKm;
        private Label LabelFeet;
        private Label LabelMetres;
        private TextBox TextBoxFeet;
        private TextBox TextBoxMetres;
    }
}