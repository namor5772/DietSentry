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
            comboBoxHelp = new ComboBox();
            SuspendLayout();
            // 
            // richTextBoxHelp
            // 
            richTextBoxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxHelp.BackColor = Color.White;
            richTextBoxHelp.BorderStyle = BorderStyle.None;
            richTextBoxHelp.Location = new Point(0, 31);
            richTextBoxHelp.Name = "richTextBoxHelp";
            richTextBoxHelp.ReadOnly = true;
            richTextBoxHelp.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxHelp.Size = new Size(935, 834);
            richTextBoxHelp.TabIndex = 1;
            richTextBoxHelp.Text = "";
            richTextBoxHelp.KeyDown += RichTextBoxHelp_KeyDown;
            // 
            // comboBoxHelp
            // 
            comboBoxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxHelp.FlatStyle = FlatStyle.System;
            comboBoxHelp.ForeColor = Color.White;
            comboBoxHelp.FormattingEnabled = true;
            comboBoxHelp.Items.AddRange(new object[] { "Diet Sentry overview", "Foods table", "Recipe table", "Eaten table", "Food DataGrid", "Food filter TextBox", "Food fields CheckBox", "Food info Label", "Food eaten dialog", "Liquid density dialog", "Eaten DataGrid", "Eaten fields CheckBox", "Eaten daily totals CheckBox", "Eaten day filter CheckBox", "Eaten info Label", "Eaten edit dialog", "Form for ADDING food", "Form for EDITING food", "Adding/Editing a non Recipe food", "Adding/Editing a Recipe food", "Recipe Ingredient filter TextBox", "Recipe Ingredient selection DataGrid", "Recipe Ingredient amount dialog", "Recipe Description TextBox", "Recipe Ingredients DataGrid", "Help system error" });
            comboBoxHelp.Location = new Point(673, 2);
            comboBoxHelp.MaxDropDownItems = 32;
            comboBoxHelp.Name = "comboBoxHelp";
            comboBoxHelp.Size = new Size(262, 23);
            comboBoxHelp.TabIndex = 2;
            comboBoxHelp.SelectedIndexChanged += ComboBoxHelp_SelectedIndexChanged;
            comboBoxHelp.Enter += ComboBoxHelp_Enter;
            comboBoxHelp.KeyDown += ComboBoxHelp_KeyDown;
            comboBoxHelp.Leave += ComboBoxHelp_Leave;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(937, 866);
            Controls.Add(comboBoxHelp);
            Controls.Add(richTextBoxHelp);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Help";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "HELP form";
            TopMost = true;
            Load += Help_Load;
            ResizeEnd += Help_ResizeEnd;
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBoxHelp;
        private ComboBox comboBoxHelp;
    }
}