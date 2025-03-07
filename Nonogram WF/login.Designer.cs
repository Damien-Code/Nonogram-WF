namespace Nonogram_WF
{
	partial class login
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
			panel1.Location = new Point(118, 88);
			panel1.Name = "panel1";
			panel1.Size = new Size(1150, 700);
			panel1.TabIndex = 0;
			// 
			// buttonLoginRegister
			// 
			buttonLoginRegister.Location = new Point(724, 494);
			buttonLoginRegister.Name = "buttonLoginRegister";
			buttonLoginRegister.Size = new Size(123, 72);
			buttonLoginRegister.TabIndex = 4;
			buttonLoginRegister.Text = "Register";
			buttonLoginRegister.UseVisualStyleBackColor = true;
			buttonLoginRegister.Click += buttonLoginRegister_Click;
			// 
			// buttonLoginLogin
			// 
			buttonLoginLogin.Location = new Point(317, 494);
			buttonLoginLogin.Name = "buttonLoginLogin";
			buttonLoginLogin.Size = new Size(130, 72);
			buttonLoginLogin.TabIndex = 3;
			buttonLoginLogin.Text = "Login";
			buttonLoginLogin.UseVisualStyleBackColor = true;
			buttonLoginLogin.Click += button1_Click;
			// 
			// textBoxLoginPassword
			// 
			textBoxLoginPassword.Location = new Point(455, 336);
			textBoxLoginPassword.Multiline = true;
			textBoxLoginPassword.Name = "textBoxLoginPassword";
			textBoxLoginPassword.Size = new Size(265, 71);
			textBoxLoginPassword.TabIndex = 2;
			textBoxLoginPassword.Text = "Password";
			// 
			// textBoxLoginEmail
			// 
			textBoxLoginEmail.Location = new Point(455, 169);
			textBoxLoginEmail.Multiline = true;
			textBoxLoginEmail.Name = "textBoxLoginEmail";
			textBoxLoginEmail.Size = new Size(265, 98);
			textBoxLoginEmail.TabIndex = 1;
			textBoxLoginEmail.Text = "Email";
			// 
			// labelLogin
			// 
			labelLogin.AutoSize = true;
			labelLogin.Font = new Font("Segoe UI", 30F);
			labelLogin.Location = new Point(498, 13);
			labelLogin.Name = "labelLogin";
			labelLogin.Size = new Size(182, 81);
			labelLogin.TabIndex = 0;
			labelLogin.Text = "Login";
			// 
			// login
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Name = "login";
			Size = new Size(1400, 925);
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
