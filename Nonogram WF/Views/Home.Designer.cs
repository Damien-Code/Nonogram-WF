namespace Nonogram_WF.Views
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonHomePlayGame = new Button();
            buttonHomeHistory = new Button();
            buttonHomeSettings = new Button();
            buttonHomeLogout = new Button();
            SuspendLayout();
            // 
            // buttonHomePlayGame
            // 
            buttonHomePlayGame.Location = new Point(411, 220);
            buttonHomePlayGame.Name = "buttonHomePlayGame";
            buttonHomePlayGame.Size = new Size(504, 229);
            buttonHomePlayGame.TabIndex = 0;
            buttonHomePlayGame.Text = "Play Game!";
            buttonHomePlayGame.UseVisualStyleBackColor = true;
            // 
            // buttonHomeHistory
            // 
            buttonHomeHistory.Location = new Point(411, 557);
            buttonHomeHistory.Name = "buttonHomeHistory";
            buttonHomeHistory.Size = new Size(223, 107);
            buttonHomeHistory.TabIndex = 1;
            buttonHomeHistory.Text = "History";
            buttonHomeHistory.UseVisualStyleBackColor = true;
            // 
            // buttonHomeSettings
            // 
            buttonHomeSettings.Location = new Point(692, 557);
            buttonHomeSettings.Name = "buttonHomeSettings";
            buttonHomeSettings.Size = new Size(223, 107);
            buttonHomeSettings.TabIndex = 2;
            buttonHomeSettings.Text = "Settings";
            buttonHomeSettings.UseVisualStyleBackColor = true;
            // 
            // buttonHomeLogout
            // 
            buttonHomeLogout.Location = new Point(1152, 28);
            buttonHomeLogout.Name = "buttonHomeLogout";
            buttonHomeLogout.Size = new Size(150, 46);
            buttonHomeLogout.TabIndex = 3;
            buttonHomeLogout.Text = "Logout";
            buttonHomeLogout.UseVisualStyleBackColor = true;
            buttonHomeLogout.Click += buttonHomeLogout_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonHomeLogout);
            Controls.Add(buttonHomeSettings);
            Controls.Add(buttonHomeHistory);
            Controls.Add(buttonHomePlayGame);
            Name = "Home";
            Size = new Size(1338, 939);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHomePlayGame;
        private Button buttonHomeHistory;
        private Button buttonHomeSettings;
        private Button buttonHomeLogout;
    }
}
