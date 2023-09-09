namespace DietSentry
{
    partial class InputForm
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
            textBoxAmount = new TextBox();
            labelAmount = new Label();
            labelDescription = new Label();
            SuspendLayout();
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(12, 31);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(89, 23);
            textBoxAmount.TabIndex = 1;
            textBoxAmount.KeyDown += textBoxAmount_KeyDown;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.ForeColor = SystemColors.HighlightText;
            labelAmount.Location = new Point(107, 34);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(33, 15);
            labelAmount.TabIndex = 2;
            labelAmount.Text = "units";
            // 
            // labelDescription
            // 
            labelDescription.AutoEllipsis = true;
            labelDescription.ForeColor = SystemColors.HighlightText;
            labelDescription.Location = new Point(12, 9);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(416, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "description";
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(440, 66);
            ControlBox = false;
            Controls.Add(labelDescription);
            Controls.Add(labelAmount);
            Controls.Add(textBoxAmount);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "InputForm";
            Text = "Amount of selected food";
            TopMost = true;
            Shown += InputForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxAmount;
        private Label labelAmount;
        private Label labelDescription;
    }
}