﻿using System.Collections.Generic;
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
            SuspendLayout();
            // 
            // richTextBoxHelp
            // 
            richTextBoxHelp.AccessibleRole = AccessibleRole.None;
            richTextBoxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxHelp.BackColor = SystemColors.Window;
            richTextBoxHelp.BorderStyle = BorderStyle.None;
            richTextBoxHelp.Location = new Point(2, 3);
            richTextBoxHelp.Name = "richTextBoxHelp";
            richTextBoxHelp.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxHelp.Size = new Size(543, 630);
            richTextBoxHelp.TabIndex = 0;
            richTextBoxHelp.Text = "";
            richTextBoxHelp.KeyDown += richTextBoxHelp_KeyDown;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(588, 637);
            Controls.Add(richTextBoxHelp);
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