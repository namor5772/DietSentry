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
            comboBoxHelp = new ComboBox();
            SuspendLayout();
            // 
            // richTextBoxHelp
            // 
            richTextBoxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxHelp.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxHelp.Location = new Point(0, 29);
            richTextBoxHelp.Name = "richTextBoxHelp";
            richTextBoxHelp.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxHelp.Size = new Size(657, 675);
            richTextBoxHelp.TabIndex = 1;
            richTextBoxHelp.Text = "";
            richTextBoxHelp.KeyDown += richTextBoxHelp_KeyDown;
            // 
            // comboBoxHelp
            // 
            comboBoxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxHelp.FlatStyle = FlatStyle.Flat;
            comboBoxHelp.FormattingEnabled = true;
            comboBoxHelp.Items.AddRange(new object[] { "Diet Sentry overview", "Foods table", "Food DataGrid", "Food filter TextBox", "Food fields CheckBox", "Food info Label", "Food eaten dialog", "Liquid density dialog", "Eaten table", "Eaten DataGrid", "Eaten fields CheckBox", "Eaten daily totals CheckBox", "Eaten day filter CheckBox", "Eaten info Label", "Eaten edit dialog" });
            comboBoxHelp.Location = new Point(0, 0);
            comboBoxHelp.Name = "comboBoxHelp";
            comboBoxHelp.Size = new Size(309, 23);
            comboBoxHelp.TabIndex = 2;
            comboBoxHelp.SelectedIndexChanged += comboBoxHelp_SelectedIndexChanged;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(659, 707);
            Controls.Add(comboBoxHelp);
            Controls.Add(richTextBoxHelp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private ComboBox comboBoxHelp;
    }
}