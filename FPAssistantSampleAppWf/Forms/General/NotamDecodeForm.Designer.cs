namespace FPAssistantSampleAppWf.Forms.General
{
    partial class NotamDecodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotamDecodeForm));
            LabelNotemMessage = new Label();
            TextBoxNotamMessage = new TextBox();
            ButtonDecodeNotam = new Button();
            LabelSeriesIdentifier = new Label();
            TextBoxSeriesIdentifier = new TextBox();
            label1 = new Label();
            TextBoxSeriesIdentifierLetter = new TextBox();
            SuspendLayout();
            // 
            // LabelNotemMessage
            // 
            LabelNotemMessage.AutoSize = true;
            LabelNotemMessage.Location = new Point(12, 9);
            LabelNotemMessage.Name = "LabelNotemMessage";
            LabelNotemMessage.Size = new Size(97, 15);
            LabelNotemMessage.TabIndex = 0;
            LabelNotemMessage.Text = "NOTAM Message";
            // 
            // TextBoxNotamMessage
            // 
            TextBoxNotamMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxNotamMessage.Location = new Point(115, 6);
            TextBoxNotamMessage.Name = "TextBoxNotamMessage";
            TextBoxNotamMessage.Size = new Size(518, 23);
            TextBoxNotamMessage.TabIndex = 1;
            // 
            // ButtonDecodeNotam
            // 
            ButtonDecodeNotam.Location = new Point(12, 42);
            ButtonDecodeNotam.Name = "ButtonDecodeNotam";
            ButtonDecodeNotam.Size = new Size(143, 23);
            ButtonDecodeNotam.TabIndex = 2;
            ButtonDecodeNotam.Text = "Decode NOTAM";
            ButtonDecodeNotam.UseVisualStyleBackColor = true;
            ButtonDecodeNotam.Click += ButtonDecodeNotam_Click;
            // 
            // LabelSeriesIdentifier
            // 
            LabelSeriesIdentifier.AutoSize = true;
            LabelSeriesIdentifier.Location = new Point(12, 86);
            LabelSeriesIdentifier.Name = "LabelSeriesIdentifier";
            LabelSeriesIdentifier.Size = new Size(87, 15);
            LabelSeriesIdentifier.TabIndex = 3;
            LabelSeriesIdentifier.Text = "Series Identifier";
            // 
            // TextBoxSeriesIdentifier
            // 
            TextBoxSeriesIdentifier.Location = new Point(258, 83);
            TextBoxSeriesIdentifier.Name = "TextBoxSeriesIdentifier";
            TextBoxSeriesIdentifier.ReadOnly = true;
            TextBoxSeriesIdentifier.Size = new Size(138, 23);
            TextBoxSeriesIdentifier.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "Series Identifier Letter";
            // 
            // TextBoxSeriesIdentifierLetter
            // 
            TextBoxSeriesIdentifierLetter.Location = new Point(258, 119);
            TextBoxSeriesIdentifierLetter.Name = "TextBoxSeriesIdentifierLetter";
            TextBoxSeriesIdentifierLetter.ReadOnly = true;
            TextBoxSeriesIdentifierLetter.Size = new Size(100, 23);
            TextBoxSeriesIdentifierLetter.TabIndex = 6;
            // 
            // NotamDecodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 399);
            Controls.Add(TextBoxSeriesIdentifierLetter);
            Controls.Add(label1);
            Controls.Add(TextBoxSeriesIdentifier);
            Controls.Add(LabelSeriesIdentifier);
            Controls.Add(ButtonDecodeNotam);
            Controls.Add(TextBoxNotamMessage);
            Controls.Add(LabelNotemMessage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NotamDecodeForm";
            Text = "NOTAM Decode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNotemMessage;
        private TextBox TextBoxNotamMessage;
        private Button ButtonDecodeNotam;
        private Label LabelSeriesIdentifier;
        private TextBox TextBoxSeriesIdentifier;
        private Label label1;
        private TextBox TextBoxSeriesIdentifierLetter;
    }
}