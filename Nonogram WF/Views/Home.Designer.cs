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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHomePlayGame
            // 
            buttonHomePlayGame.Location = new Point(493, 243);
            buttonHomePlayGame.Name = "buttonHomePlayGame";
            buttonHomePlayGame.Size = new Size(504, 229);
            buttonHomePlayGame.TabIndex = 0;
            buttonHomePlayGame.Text = "Play Game!";
            buttonHomePlayGame.UseVisualStyleBackColor = true;
            buttonHomePlayGame.Click += buttonHomePlayGame_Click;
            // 
            // buttonHomeHistory
            // 
            buttonHomeHistory.Location = new Point(493, 578);
            buttonHomeHistory.Name = "buttonHomeHistory";
            buttonHomeHistory.Size = new Size(223, 107);
            buttonHomeHistory.TabIndex = 1;
            buttonHomeHistory.Text = "History";
            buttonHomeHistory.UseVisualStyleBackColor = true;
            // 
            // buttonHomeSettings
            // 
            buttonHomeSettings.Location = new Point(774, 578);
            buttonHomeSettings.Name = "buttonHomeSettings";
            buttonHomeSettings.Size = new Size(223, 107);
            buttonHomeSettings.TabIndex = 2;
            buttonHomeSettings.Text = "Settings";
            buttonHomeSettings.UseVisualStyleBackColor = true;
            // 
            // buttonHomeLogout
            // 
            buttonHomeLogout.Location = new Point(1170, 26);
            buttonHomeLogout.Name = "buttonHomeLogout";
            buttonHomeLogout.Size = new Size(150, 46);
            buttonHomeLogout.TabIndex = 3;
            buttonHomeLogout.Text = "Logout";
            buttonHomeLogout.UseVisualStyleBackColor = true;
            buttonHomeLogout.Click += buttonHomeLogout_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(buttonHomePlayGame);
            panel1.Controls.Add(buttonHomeLogout);
            panel1.Controls.Add(buttonHomeHistory);
            panel1.Controls.Add(buttonHomeSettings);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1513, 930);
            panel1.TabIndex = 4;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Home";
            Size = new Size(1513, 930);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHomePlayGame;
        private Button buttonHomeHistory;
        private Button buttonHomeSettings;
        private Button buttonHomeLogout;
        private Panel panel1;
    }
}
