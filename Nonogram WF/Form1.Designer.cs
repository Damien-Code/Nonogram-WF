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
            Login = new login();
            welcome2 = new Welcome();
            Instructions = new Views.Instructions();
            Home = new Views.Home();
            Difficulty = new Views.Difficulty();
            GameScreen = new Views.GameScreen();
            History = new Views.History();
            Settings = new Views.Settings();
            Registration = new Views.Registration();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Dock = DockStyle.Fill;
            Login.Location = new Point(0, 0);
            Login.Margin = new Padding(4);
            Login.Name = "Login";
            Login.Size = new Size(1479, 907);
            Login.TabIndex = 0;
            Login.Visible = false;
            // 
            // welcome2
            // 
            welcome2.BackColor = Color.White;
            welcome2.Dock = DockStyle.Fill;
            welcome2.Location = new Point(0, 0);
            welcome2.Name = "welcome2";
            welcome2.Size = new Size(1479, 907);
            welcome2.TabIndex = 0;
            // 
            // Instructions
            // 
            Instructions.Dock = DockStyle.Fill;
            Instructions.Location = new Point(0, 0);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(1479, 907);
            Instructions.TabIndex = 1;
            Instructions.Visible = false;
            // 
            // Home
            // 
            Home.Dock = DockStyle.Fill;
            Home.Location = new Point(0, 0);
            Home.Name = "Home";
            Home.Size = new Size(1479, 907);
            Home.TabIndex = 2;
            Home.Visible = false;
            // 
            // Difficulty
            // 
            Difficulty.Location = new Point(0, 0);
            Difficulty.Name = "Difficulty";
            Difficulty.Size = new Size(1489, 934);
            Difficulty.TabIndex = 3;
            Difficulty.Visible = false;
            // 
            // GameScreen
            // 
            GameScreen.Location = new Point(0, 0);
            GameScreen.Name = "GameScreen";
            GameScreen.Size = new Size(1489, 934);
            GameScreen.TabIndex = 4;
            GameScreen.Visible = false;
            // 
            // History
            // 
            History.Location = new Point(0, 0);
            History.Name = "History";
            History.Size = new Size(1489, 934);
            History.TabIndex = 5;
            History.Visible = false;
            // 
            // Settings
            // 
            Settings.Anchor = AnchorStyles.None;
            Settings.Location = new Point(-5, -14);
            Settings.Name = "Settings";
            Settings.Size = new Size(1489, 934);
            Settings.TabIndex = 6;
            Settings.Visible = false;
            // 
            // Registration
            // 
            Registration.Dock = DockStyle.Fill;
            Registration.Location = new Point(0, 0);
            Registration.Margin = new Padding(4);
            Registration.Name = "Registration";
            Registration.Size = new Size(1479, 907);
            Registration.TabIndex = 7;
            Registration.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 907);
            Controls.Add(welcome2);
            Controls.Add(Difficulty);
            Controls.Add(Home);
            Controls.Add(Instructions);
            Controls.Add(Login);
            Controls.Add(GameScreen);
            Controls.Add(History);
            Controls.Add(Settings);
            Controls.Add(Registration);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private login login1;
        private Welcome welcome2;
        private Views.Instructions Instructions;
        private Views.Home Home;
        private Views.Difficulty difficulty1;
        private Views.Difficulty Difficulty;
        private Views.GameScreen GameScreen;
        private Views.History History;
        private Views.Settings Settings;
        private Views.Registration Registration;
        private login Login;
    }

}
