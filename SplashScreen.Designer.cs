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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            aTimer = new System.Windows.Forms.Timer(components);
            pictureBoxSplashScreen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSplashScreen).BeginInit();
            SuspendLayout();
            // 
            // aTimer
            // 
            aTimer.Enabled = true;
            aTimer.Interval = 50;
            aTimer.Tick += ATimer_Tick;
            // 
            // pictureBoxSplashScreen
            // 
            pictureBoxSplashScreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxSplashScreen.Image = (Image)resources.GetObject("pictureBoxSplashScreen.Image");
            pictureBoxSplashScreen.Location = new Point(12, 12);
            pictureBoxSplashScreen.Name = "pictureBoxSplashScreen";
            pictureBoxSplashScreen.Size = new Size(496, 434);
            pictureBoxSplashScreen.TabIndex = 0;
            pictureBoxSplashScreen.TabStop = false;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(520, 458);
            Controls.Add(pictureBoxSplashScreen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash Screen";
            TransparencyKey = Color.Lime;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSplashScreen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer aTimer;
        private PictureBox pictureBoxSplashScreen;
    }
}