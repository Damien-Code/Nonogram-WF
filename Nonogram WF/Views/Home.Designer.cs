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
            buttonHomePlayGame.Location = new Point(265, 114);
            buttonHomePlayGame.Margin = new Padding(2, 1, 2, 1);
            buttonHomePlayGame.Name = "buttonHomePlayGame";
            buttonHomePlayGame.Size = new Size(271, 107);
            buttonHomePlayGame.TabIndex = 0;
            buttonHomePlayGame.Text = "Play Game!";
            buttonHomePlayGame.UseVisualStyleBackColor = true;
            buttonHomePlayGame.Click += buttonHomePlayGame_Click;
            // 
            // buttonHomeHistory
            // 
            buttonHomeHistory.Location = new Point(265, 271);
            buttonHomeHistory.Margin = new Padding(2, 1, 2, 1);
            buttonHomeHistory.Name = "buttonHomeHistory";
            buttonHomeHistory.Size = new Size(120, 50);
            buttonHomeHistory.TabIndex = 1;
            buttonHomeHistory.Text = "History";
            buttonHomeHistory.UseVisualStyleBackColor = true;
            buttonHomeHistory.Click += buttonHomeHistory_Click;
            // 
            // buttonHomeSettings
            // 
            buttonHomeSettings.Location = new Point(417, 271);
            buttonHomeSettings.Margin = new Padding(2, 1, 2, 1);
            buttonHomeSettings.Name = "buttonHomeSettings";
            buttonHomeSettings.Size = new Size(120, 50);
            buttonHomeSettings.TabIndex = 2;
            buttonHomeSettings.Text = "Settings";
            buttonHomeSettings.UseVisualStyleBackColor = true;
            buttonHomeSettings.Click += buttonHomeSettings_Click;
            // 
            // buttonHomeLogout
            // 
            buttonHomeLogout.Location = new Point(687, 12);
            buttonHomeLogout.Margin = new Padding(2, 1, 2, 1);
            buttonHomeLogout.Name = "buttonHomeLogout";
            buttonHomeLogout.Size = new Size(81, 22);
            buttonHomeLogout.TabIndex = 3;
            buttonHomeLogout.Text = "Logout";
            buttonHomeLogout.UseVisualStyleBackColor = true;
            buttonHomeLogout.Click += buttonHomeLogout_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHomePlayGame);
            panel1.Controls.Add(buttonHomeLogout);
            panel1.Controls.Add(buttonHomeHistory);
            panel1.Controls.Add(buttonHomeSettings);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 434);
            panel1.TabIndex = 4;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Home";
            Size = new Size(754, 434);
            VisibleChanged += Home_VisibleChanged;
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
