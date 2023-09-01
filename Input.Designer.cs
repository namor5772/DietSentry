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
            buttonOK = new Button();
            textBoxAmount = new TextBox();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(40, 32);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += button1_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(145, 32);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(118, 23);
            textBoxAmount.TabIndex = 1;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 90);
            ControlBox = false;
            Controls.Add(textBoxAmount);
            Controls.Add(buttonOK);
            Name = "InputForm";
            Text = "Input";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private TextBox textBoxAmount;
    }
}