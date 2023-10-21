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

        // string used to find context sensitive help in rtf file
        public string sHelpFind = "BLANK";


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
            dateTimePickerEaten = new DateTimePicker();
            labelHelpFoodEatenDialog = new Label();
            SuspendLayout();
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(23, 41);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(89, 23);
            textBoxAmount.TabIndex = 1;
            textBoxAmount.KeyDown += TextBoxAmount_KeyDown;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.ForeColor = SystemColors.HighlightText;
            labelAmount.Location = new Point(125, 44);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(33, 15);
            labelAmount.TabIndex = 2;
            labelAmount.Text = "units";
            // 
            // labelDescription
            // 
            labelDescription.AutoEllipsis = true;
            labelDescription.ForeColor = SystemColors.HighlightText;
            labelDescription.Location = new Point(23, 9);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(347, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "description";
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
            dateTimePickerEaten.TabIndex = 4;
            dateTimePickerEaten.KeyDown += DateTimePickerEaten_KeyDown;
            // 
            // labelHelpFoodEatenDialog
            // 
            labelHelpFoodEatenDialog.AutoSize = true;
            labelHelpFoodEatenDialog.BackColor = Color.YellowGreen;
            labelHelpFoodEatenDialog.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpFoodEatenDialog.ForeColor = SystemColors.ButtonHighlight;
            labelHelpFoodEatenDialog.Location = new Point(5, 9);
            labelHelpFoodEatenDialog.Name = "labelHelpFoodEatenDialog";
            labelHelpFoodEatenDialog.Size = new Size(14, 15);
            labelHelpFoodEatenDialog.TabIndex = 15;
            labelHelpFoodEatenDialog.Text = "?";
            labelHelpFoodEatenDialog.MouseHover += LabelHelpFoodEatenDialog_MouseHover;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(403, 96);
            ControlBox = false;
            Controls.Add(labelHelpFoodEatenDialog);
            Controls.Add(dateTimePickerEaten);
            Controls.Add(labelDescription);
            Controls.Add(labelAmount);
            Controls.Add(textBoxAmount);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "InputForm";
            Text = "InputFood";
            TopMost = true;
            Shown += InputForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxAmount;
        private Label labelAmount;
        private Label labelDescription;
        private DateTimePicker dateTimePickerEaten;
        private Label labelHelpFoodEatenDialog;
    }
}