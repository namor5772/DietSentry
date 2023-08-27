namespace DietSentry
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl2 = new TabControl();
            tabPageFood = new TabPage();
            tabPageEaten = new TabPage();
            tabControl1.SuspendLayout();
            tabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(522, 343);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(13, 8);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(5, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(5, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPageFood);
            tabControl2.Controls.Add(tabPageEaten);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1170, 636);
            tabControl2.TabIndex = 1;
            // 
            // tabPageFood
            // 
            tabPageFood.Location = new Point(4, 24);
            tabPageFood.Name = "tabPageFood";
            tabPageFood.Padding = new Padding(3);
            tabPageFood.Size = new Size(1132, 608);
            tabPageFood.TabIndex = 0;
            tabPageFood.Text = "Food";
            tabPageFood.UseVisualStyleBackColor = true;
            // 
            // tabPageEaten
            // 
            tabPageEaten.Location = new Point(4, 24);
            tabPageEaten.Name = "tabPageEaten";
            tabPageEaten.Padding = new Padding(3);
            tabPageEaten.Size = new Size(1162, 608);
            tabPageEaten.TabIndex = 1;
            tabPageEaten.Text = "Eaten";
            tabPageEaten.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 636);
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Diet Sentry";
            tabControl1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPageFood;
        private TabPage tabPageEaten;
    }
}