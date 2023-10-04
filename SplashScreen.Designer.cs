namespace DietSentry
{
    partial class SplashScreen
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

        // counter for timer ticks
        private int iTick = 0;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            aTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // aTimer
            // 
            aTimer.Enabled = true;
            aTimer.Interval = 50;
            aTimer.Tick += aTimer_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(601, 331);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash Screen";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer aTimer;
    }
}