namespace DietSentry
{
    partial class Help
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
            richTextBoxHelp = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxHelp
            // 
            richTextBoxHelp.AccessibleRole = AccessibleRole.None;
            richTextBoxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxHelp.BackColor = SystemColors.Info;
            richTextBoxHelp.BorderStyle = BorderStyle.None;
            richTextBoxHelp.Location = new Point(0, 83);
            richTextBoxHelp.Margin = new Padding(4, 5, 4, 5);
            richTextBoxHelp.Name = "richTextBoxHelp";
            richTextBoxHelp.ReadOnly = true;
            richTextBoxHelp.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxHelp.Size = new Size(1143, 667);
            richTextBoxHelp.TabIndex = 0;
            richTextBoxHelp.Text = "";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(richTextBoxHelp);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Help";
            ShowIcon = false;
            Text = "HELP form";
            TopMost = true;
            Load += Help_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxHelp;
    }
}