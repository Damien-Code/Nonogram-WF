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
            Login = new Views.Login();
            Welcome = new Views.Welcome();
            Instructions = new Views.Instructions();
            Home = new Views.Home();
            Difficulty = new Views.Difficulty();
            GameScreen = new Views.GameScreen();
            Settings = new Views.Settings();
            Registration = new Views.Registration();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Dock = DockStyle.Fill;
            Login.Location = new Point(0, 0);
            Login.Margin = new Padding(0);
            Login.Name = "Login";
            Login.Size = new Size(784, 436);
            Login.TabIndex = 0;
            Login.Visible = false;
            // 
            // Welcome
            // 
            Welcome.BackColor = Color.White;
            Welcome.Dock = DockStyle.Fill;
            Welcome.Location = new Point(0, 0);
            Welcome.Margin = new Padding(1, 0, 1, 0);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(784, 436);
            Welcome.TabIndex = 0;
            Welcome.Load += welcome2_Load;
            // 
            // Instructions
            // 
            Instructions.Dock = DockStyle.Fill;
            Instructions.Location = new Point(0, 0);
            Instructions.Margin = new Padding(1, 0, 1, 0);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(784, 436);
            Instructions.TabIndex = 1;
            Instructions.Visible = false;
            // 
            // Home
            // 
            Home.Dock = DockStyle.Fill;
            Home.Location = new Point(0, 0);
            Home.Margin = new Padding(1, 0, 1, 0);
            Home.Name = "Home";
            Home.Size = new Size(784, 436);
            Home.TabIndex = 2;
            Home.Visible = false;
            // 
            // Difficulty
            // 
            Difficulty.Dock = DockStyle.Fill;
            Difficulty.Location = new Point(0, 0);
            Difficulty.Margin = new Padding(1, 0, 1, 0);
            Difficulty.Name = "Difficulty";
            Difficulty.Size = new Size(784, 436);
            Difficulty.TabIndex = 3;
            Difficulty.Visible = false;
            // 
            // GameScreen
            // 
            GameScreen.Dock = DockStyle.Fill;
            GameScreen.Location = new Point(0, 0);
            GameScreen.Margin = new Padding(1, 0, 1, 0);
            GameScreen.Name = "GameScreen";
            GameScreen.Size = new Size(784, 436);
            GameScreen.TabIndex = 4;
            GameScreen.Visible = false;
            // 
            // Settings
            // 
            Settings.Dock = DockStyle.Fill;
            Settings.Location = new Point(0, 0);
            Settings.Margin = new Padding(1, 0, 1, 0);
            Settings.Name = "Settings";
            Settings.Size = new Size(784, 436);
            Settings.TabIndex = 6;
            Settings.Visible = false;
            // 
            // Registration
            // 
            Registration.Dock = DockStyle.Fill;
            Registration.Location = new Point(0, 0);
            Registration.Margin = new Padding(0);
            Registration.Name = "Registration";
            Registration.Size = new Size(784, 436);
            Registration.TabIndex = 7;
            Registration.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 436);
            Controls.Add(Welcome);
            Controls.Add(Difficulty);
            Controls.Add(Home);
            Controls.Add(Instructions);
            Controls.Add(Login);
            Controls.Add(GameScreen);
            Controls.Add(Settings);
            Controls.Add(Registration);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Views.Welcome Welcome;
        private Views.Instructions Instructions;
        private Views.Home Home;
        private Views.Difficulty difficulty1;
        private Views.Difficulty Difficulty;
        private Views.GameScreen GameScreen;
        private Views.Settings Settings;
        private Views.Registration Registration;
        private Views.Login Login;
        private Views.History History;
    }

}
