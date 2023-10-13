namespace DietSentry
{
    partial class InputDensity
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
            textBoxDensity = new TextBox();
            labelDescription = new Label();
            labelDensity = new Label();
            SuspendLayout();
            // 
            // textBoxDensity
            // 
            textBoxDensity.Location = new Point(23, 37);
            textBoxDensity.Name = "textBoxDensity";
            textBoxDensity.Size = new Size(89, 23);
            textBoxDensity.TabIndex = 6;
            textBoxDensity.KeyDown += textBoxDensity_KeyDown;
            // 
            // labelDescription
            // 
            labelDescription.AutoEllipsis = true;
            labelDescription.ForeColor = SystemColors.HighlightText;
            labelDescription.Location = new Point(12, 9);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(358, 15);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "description";
            // 
            // labelDensity
            // 
            labelDensity.AutoSize = true;
            labelDensity.ForeColor = SystemColors.HighlightText;
            labelDensity.Location = new Point(125, 40);
            labelDensity.Name = "labelDensity";
            labelDensity.Size = new Size(90, 15);
            labelDensity.TabIndex = 8;
            labelDensity.Text = "density in g/mL";
            // 
            // InputDensity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(382, 78);
            ControlBox = false;
            Controls.Add(labelDensity);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDensity);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputDensity";
            Text = "InputDensity";
            Shown += InputDensity_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDensity;
        private Label labelDescription;
        private Label labelDensity;
    }
}