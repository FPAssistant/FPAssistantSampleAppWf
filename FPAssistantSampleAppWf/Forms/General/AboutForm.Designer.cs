namespace FPAssistantSampleAppWf.Forms.General
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            ButtonClose = new Button();
            LabelFPAssistantSdkVersion = new Label();
            LabelDeveloperName = new Label();
            PictureBoxFPAssistantLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFPAssistantLogo).BeginInit();
            SuspendLayout();
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.Location = new Point(318, 156);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(105, 27);
            ButtonClose.TabIndex = 0;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // LabelFPAssistantSdkVersion
            // 
            LabelFPAssistantSdkVersion.AutoSize = true;
            LabelFPAssistantSdkVersion.Location = new Point(21, 42);
            LabelFPAssistantSdkVersion.Name = "LabelFPAssistantSdkVersion";
            LabelFPAssistantSdkVersion.Size = new Size(69, 15);
            LabelFPAssistantSdkVersion.TabIndex = 1;
            LabelFPAssistantSdkVersion.Text = "SDK Version";
            // 
            // LabelDeveloperName
            // 
            LabelDeveloperName.AutoSize = true;
            LabelDeveloperName.Location = new Point(21, 9);
            LabelDeveloperName.Name = "LabelDeveloperName";
            LabelDeveloperName.Size = new Size(95, 15);
            LabelDeveloperName.TabIndex = 2;
            LabelDeveloperName.Text = "Developer Name";
            // 
            // PictureBoxFPAssistantLogo
            // 
            PictureBoxFPAssistantLogo.Image = (Image)resources.GetObject("PictureBoxFPAssistantLogo.Image");
            PictureBoxFPAssistantLogo.Location = new Point(21, 95);
            PictureBoxFPAssistantLogo.Name = "PictureBoxFPAssistantLogo";
            PictureBoxFPAssistantLogo.Size = new Size(111, 111);
            PictureBoxFPAssistantLogo.TabIndex = 3;
            PictureBoxFPAssistantLogo.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 209);
            Controls.Add(PictureBoxFPAssistantLogo);
            Controls.Add(LabelDeveloperName);
            Controls.Add(LabelFPAssistantSdkVersion);
            Controls.Add(ButtonClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutForm";
            Text = "About FPAssistant SDK";
            ((System.ComponentModel.ISupportInitialize)PictureBoxFPAssistantLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonClose;
        private Label LabelFPAssistantSdkVersion;
        private Label LabelDeveloperName;
        private PictureBox PictureBoxFPAssistantLogo;
    }
}