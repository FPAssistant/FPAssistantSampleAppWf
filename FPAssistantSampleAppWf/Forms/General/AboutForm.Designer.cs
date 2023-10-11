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
            SuspendLayout();
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.Location = new Point(208, 210);
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
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 263);
            Controls.Add(LabelFPAssistantSdkVersion);
            Controls.Add(ButtonClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutForm";
            Text = "About FPAssistant SDK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonClose;
        private Label LabelFPAssistantSdkVersion;
    }
}