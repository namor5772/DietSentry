namespace DietSentry
{
    partial class InputEaten
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
            dateTimePickerEaten = new DateTimePicker();
            labelDescription = new Label();
            labelHelpEatenEditDialog = new Label();
            SuspendLayout();
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(23, 41);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(89, 23);
            textBoxAmount.TabIndex = 2;
            textBoxAmount.KeyDown += TextBoxAmount_KeyDown;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.ForeColor = SystemColors.HighlightText;
            labelAmount.Location = new Point(125, 44);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(33, 15);
            labelAmount.TabIndex = 3;
            labelAmount.Text = "units";
            // 
            // dateTimePickerEaten
            // 
            dateTimePickerEaten.CustomFormat = "  dd-MMM-yyyy   HH : mm";
            dateTimePickerEaten.Format = DateTimePickerFormat.Custom;
            dateTimePickerEaten.Location = new Point(195, 41);
            dateTimePickerEaten.MaxDate = new DateTime(2123, 1, 1, 0, 0, 0, 0);
            dateTimePickerEaten.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePickerEaten.Name = "dateTimePickerEaten";
            dateTimePickerEaten.Size = new Size(186, 23);
            dateTimePickerEaten.TabIndex = 5;
            dateTimePickerEaten.KeyDown += DateTimePickerEaten_KeyDown;
            // 
            // labelDescription
            // 
            labelDescription.AutoEllipsis = true;
            labelDescription.ForeColor = SystemColors.HighlightText;
            labelDescription.Location = new Point(23, 9);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(368, 15);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "description";
            // 
            // labelHelpEatenEditDialog
            // 
            labelHelpEatenEditDialog.BackColor = Color.YellowGreen;
            labelHelpEatenEditDialog.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpEatenEditDialog.ForeColor = SystemColors.ButtonHighlight;
            labelHelpEatenEditDialog.Location = new Point(5, 9);
            labelHelpEatenEditDialog.Name = "labelHelpEatenEditDialog";
            labelHelpEatenEditDialog.Size = new Size(14, 15);
            labelHelpEatenEditDialog.TabIndex = 17;
            labelHelpEatenEditDialog.Text = "?";
            labelHelpEatenEditDialog.MouseHover += labelHelpEatenEditDialog_MouseHover;
            // 
            // InputEaten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(403, 96);
            ControlBox = false;
            Controls.Add(labelHelpEatenEditDialog);
            Controls.Add(labelDescription);
            Controls.Add(dateTimePickerEaten);
            Controls.Add(labelAmount);
            Controls.Add(textBoxAmount);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "InputEaten";
            Text = "InputEaten";
            TopMost = true;
            Shown += InputEaten_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAmount;
        private Label labelAmount;
        private DateTimePicker dateTimePickerEaten;
        private Label labelDescription;
        private Label labelHelpEatenEditDialog;
    }
}