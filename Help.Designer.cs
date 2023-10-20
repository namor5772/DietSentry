using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;

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
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // richTextBoxHelp
            // 
            richTextBoxHelp.AccessibleRole = AccessibleRole.None;
            richTextBoxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxHelp.BackColor = SystemColors.Info;
            richTextBoxHelp.BorderStyle = BorderStyle.None;
            richTextBoxHelp.Location = new Point(2, 50);
            richTextBoxHelp.Name = "richTextBoxHelp";
            richTextBoxHelp.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxHelp.Size = new Size(755, 396);
            richTextBoxHelp.TabIndex = 0;
            richTextBoxHelp.Text = "";
            richTextBoxHelp.KeyDown += richTextBoxHelp_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBoxHelp);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Help";
            ShowIcon = false;
            Text = "HELP form";
            TopMost = true;
            Load += Help_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxHelp;
        private System.Windows.Forms.Label label1;
    }
}