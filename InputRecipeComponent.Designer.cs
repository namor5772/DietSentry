namespace DietSentry
{
    partial class InputRecipeComponent
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
            labelDescription = new Label();
            textBoxAmount = new TextBox();
            labelAmount = new Label();
            labelHelpRecipeDialog = new Label();
            SuspendLayout();
            // 
            // labelDescription
            // 
            labelDescription.AutoEllipsis = true;
            labelDescription.ForeColor = SystemColors.HighlightText;
            labelDescription.Location = new Point(23, 9);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(347, 15);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "description";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(23, 37);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(89, 23);
            textBoxAmount.TabIndex = 5;
            textBoxAmount.KeyDown += TextBoxAmount_KeyDown;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.ForeColor = SystemColors.HighlightText;
            labelAmount.Location = new Point(125, 40);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(33, 15);
            labelAmount.TabIndex = 6;
            labelAmount.Text = "units";
            // 
            // labelHelpRecipeDialog
            // 
            labelHelpRecipeDialog.BackColor = Color.YellowGreen;
            labelHelpRecipeDialog.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpRecipeDialog.ForeColor = SystemColors.ButtonHighlight;
            labelHelpRecipeDialog.Location = new Point(3, 9);
            labelHelpRecipeDialog.Name = "labelHelpRecipeDialog";
            labelHelpRecipeDialog.Size = new Size(14, 15);
            labelHelpRecipeDialog.TabIndex = 18;
            labelHelpRecipeDialog.Text = "?";
            labelHelpRecipeDialog.MouseHover += labelHelpRecipeDialog_MouseHover;
            // 
            // InputRecipeComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(382, 78);
            ControlBox = false;
            Controls.Add(labelHelpRecipeDialog);
            Controls.Add(labelAmount);
            Controls.Add(textBoxAmount);
            Controls.Add(labelDescription);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "InputRecipeComponent";
            Text = "Amount of selected food";
            TopMost = true;
            Shown += InputRecipeComponent_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDescription;
        private TextBox textBoxAmount;
        private Label labelAmount;
        private Label labelHelpRecipeDialog;
    }
}