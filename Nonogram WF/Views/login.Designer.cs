namespace Nonogram_WF.Views
{
	partial class Login
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
            panel1 = new Panel();
            buttonLoginRegister = new Button();
            buttonLoginLogin = new Button();
            textBoxLoginPassword = new TextBox();
            textBoxLoginEmail = new TextBox();
            labelLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLoginRegister);
            panel1.Controls.Add(buttonLoginLogin);
            panel1.Controls.Add(textBoxLoginPassword);
            panel1.Controls.Add(textBoxLoginEmail);
            panel1.Controls.Add(labelLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 475);
            panel1.TabIndex = 0;
            // 
            // buttonLoginRegister
            // 
            buttonLoginRegister.Location = new Point(489, 363);
            buttonLoginRegister.Margin = new Padding(0);
            buttonLoginRegister.Name = "buttonLoginRegister";
            buttonLoginRegister.Size = new Size(139, 42);
            buttonLoginRegister.TabIndex = 4;
            buttonLoginRegister.Text = "Don't have an account?";
            buttonLoginRegister.UseVisualStyleBackColor = true;
            buttonLoginRegister.Click += buttonLoginRegister_Click;
            // 
            // buttonLoginLogin
            // 
            buttonLoginLogin.Location = new Point(189, 363);
            buttonLoginLogin.Margin = new Padding(0);
            buttonLoginLogin.Name = "buttonLoginLogin";
            buttonLoginLogin.Size = new Size(139, 42);
            buttonLoginLogin.TabIndex = 3;
            buttonLoginLogin.Text = "Login";
            buttonLoginLogin.UseVisualStyleBackColor = true;
            buttonLoginLogin.Click += button1_Click;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.Location = new Point(259, 261);
            textBoxLoginPassword.Margin = new Padding(2, 1, 2, 1);
            textBoxLoginPassword.Multiline = true;
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.PasswordChar = '*';
            textBoxLoginPassword.PlaceholderText = "Password:";
            textBoxLoginPassword.Size = new Size(300, 23);
            textBoxLoginPassword.TabIndex = 2;
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.Location = new Point(259, 172);
            textBoxLoginEmail.Margin = new Padding(2, 1, 2, 1);
            textBoxLoginEmail.Multiline = true;
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.PlaceholderText = "Email:";
            textBoxLoginEmail.Size = new Size(300, 23);
            textBoxLoginEmail.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(362, 62);
            labelLogin.Margin = new Padding(2, 0, 2, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(115, 51);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "Login";
            Size = new Size(800, 475);
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private TextBox textBoxLoginEmail;
		private Label labelLogin;
		private TextBox textBoxLoginPassword;
		private Button buttonLoginRegister;
		private Button buttonLoginLogin;
	}
}
