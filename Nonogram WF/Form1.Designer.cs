using Microsoft.VisualBasic.Logging;
using Nonogram_WF.Views;

namespace Nonogram_WF
{
    partial class Form1
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





        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login1 = new Login();
            welcome2 = new Welcome();
            Instructions = new Instructions();
            Home = new Home();
            Difficulty = new Difficulty();
            GameScreen = new GameScreen();
            history1 = new History();
            Settings = new Settings();
            Registration = new Registration();
            SuspendLayout();
            // 
            // login1
            // 
            login1.Dock = DockStyle.Fill;
            login1.Location = new Point(0, 0);
            login1.Margin = new Padding(2);
            login1.Name = "login1";
            login1.Size = new Size(778, 413);
            login1.TabIndex = 0;
            login1.Visible = false;
            // 
            // welcome2
            // 
            welcome2.BackColor = Color.White;
            welcome2.Dock = DockStyle.Fill;
            welcome2.Location = new Point(0, 0);
            welcome2.Margin = new Padding(1, 0, 1, 0);
            welcome2.Name = "welcome2";
            welcome2.Size = new Size(796, 425);
            welcome2.TabIndex = 0;
            welcome2.Load += welcome2_Load;
            // 
            // Instructions
            // 
            Instructions.Dock = DockStyle.Fill;
            Instructions.Location = new Point(0, 0);
            Instructions.Margin = new Padding(1, 0, 1, 0);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(778, 413);
            Instructions.TabIndex = 1;
            Instructions.Visible = false;
            // 
            // Home
            // 
            Home.Dock = DockStyle.Fill;
            Home.Location = new Point(0, 0);
            Home.Margin = new Padding(1, 0, 1, 0);
            Home.Name = "Home";
            Home.Size = new Size(778, 413);
            Home.TabIndex = 2;
            Home.Visible = false;
            // 
            // Difficulty
            // 
            Difficulty.Location = new Point(0, 0);
            Difficulty.Margin = new Padding(1, 0, 1, 0);
            Difficulty.Name = "Difficulty";
            Difficulty.Size = new Size(802, 438);
            Difficulty.TabIndex = 3;
            Difficulty.Visible = false;
            // 
            // GameScreen
            // 
            GameScreen.Location = new Point(0, 0);
            GameScreen.Margin = new Padding(1, 0, 1, 0);
            GameScreen.Name = "GameScreen";
            GameScreen.Size = new Size(802, 438);
            GameScreen.TabIndex = 4;
            GameScreen.Visible = false;
            // 
            // history1
            // 
            history1.Location = new Point(0, 0);
            history1.Margin = new Padding(1, 0, 1, 0);
            history1.Name = "history1";
            history1.Size = new Size(802, 438);
            history1.TabIndex = 5;
            history1.Visible = false;
            // 
            // Settings
            // 
            Settings.Anchor = AnchorStyles.None;
            Settings.Location = new Point(-3, -7);
            Settings.Margin = new Padding(1, 0, 1, 0);
            Settings.Name = "Settings";
            Settings.Size = new Size(802, 438);
            Settings.TabIndex = 6;
            Settings.Visible = false;
            // 
            // Registration
            // 
            Registration.Dock = DockStyle.Fill;
            Registration.Location = new Point(0, 0);
            Registration.Margin = new Padding(2);
            Registration.Name = "Registration";
            Registration.Size = new Size(778, 413);
            Registration.TabIndex = 7;
            Registration.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 413);
            Controls.Add(welcome2);
            Controls.Add(history1);
            Controls.Add(Settings);
            Controls.Add(Registration);
            Controls.Add(Difficulty);
            Controls.Add(Home);
            Controls.Add(Instructions);
            Controls.Add(login1);
            Controls.Add(GameScreen);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        //private Views.Welcome Welcome;
        //private Views.Instructions Instructions;
        //private Views.Home Home;
        //private Views.Difficulty Difficulty;
        //private Views.GameScreen GameScreen;
        //private Views.Settings Settings;
        //private Views.Registration Registration;
        //private Views.Login Login;
        //private Views.History history1;
        private Views.Login login1;
        private Views.Welcome welcome2;
        private Views.Instructions Instructions;
        private Views.Home Home;
        private Views.Difficulty difficulty1;
        private Views.Difficulty Difficulty;
        private Views.GameScreen GameScreen;
        private Views.History history1;
        private Views.Settings Settings;
        private Views.Registration Registration;
        //private login Login;
    }

}
