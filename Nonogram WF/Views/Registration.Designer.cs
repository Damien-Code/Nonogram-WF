namespace Nonogram_WF.Views
{
    partial class Registration
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
            label1 = new Label();
            textBoxRegisterEmail = new TextBox();
            textBoxRegisterPassword = new TextBox();
            textBoxRegisterConfirm = new TextBox();
            buttonRegisterRegister = new Button();
            buttonRegisterLogin = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 89);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(157, 51);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // textBoxRegisterEmail
            // 
            textBoxRegisterEmail.Location = new Point(269, 170);
            textBoxRegisterEmail.Margin = new Padding(2, 1, 2, 1);
            textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            textBoxRegisterEmail.PlaceholderText = "Email:";
            textBoxRegisterEmail.Size = new Size(258, 23);
            textBoxRegisterEmail.TabIndex = 1;
            // 
            // textBoxRegisterPassword
            // 
            textBoxRegisterPassword.Location = new Point(269, 223);
            textBoxRegisterPassword.Margin = new Padding(2, 1, 2, 1);
            textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            textBoxRegisterPassword.PasswordChar = '*';
            textBoxRegisterPassword.PlaceholderText = "Password:";
            textBoxRegisterPassword.Size = new Size(258, 23);
            textBoxRegisterPassword.TabIndex = 2;
            // 
            // textBoxRegisterConfirm
            // 
            textBoxRegisterConfirm.Location = new Point(269, 270);
            textBoxRegisterConfirm.Margin = new Padding(2, 1, 2, 1);
            textBoxRegisterConfirm.Name = "textBoxRegisterConfirm";
            textBoxRegisterConfirm.PasswordChar = '*';
            textBoxRegisterConfirm.PlaceholderText = "Confirm Password:";
            textBoxRegisterConfirm.Size = new Size(258, 23);
            textBoxRegisterConfirm.TabIndex = 3;
            // 
            // buttonRegisterRegister
            // 
            buttonRegisterRegister.Anchor = AnchorStyles.None;
            buttonRegisterRegister.Location = new Point(162, 352);
            buttonRegisterRegister.Margin = new Padding(0);
            buttonRegisterRegister.Name = "buttonRegisterRegister";
            buttonRegisterRegister.Size = new Size(139, 42);
            buttonRegisterRegister.TabIndex = 4;
            buttonRegisterRegister.Text = "Register";
            buttonRegisterRegister.UseVisualStyleBackColor = true;
            buttonRegisterRegister.Click += buttonRegisterRegister_Click;
            // 
            // buttonRegisterLogin
            // 
            buttonRegisterLogin.Anchor = AnchorStyles.None;
            buttonRegisterLogin.Location = new Point(512, 352);
            buttonRegisterLogin.Margin = new Padding(0);
            buttonRegisterLogin.Name = "buttonRegisterLogin";
            buttonRegisterLogin.Size = new Size(139, 42);
            buttonRegisterLogin.TabIndex = 5;
            buttonRegisterLogin.Text = "Already have an account?";
            buttonRegisterLogin.UseVisualStyleBackColor = true;
            buttonRegisterLogin.Click += buttonRegisterLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonRegisterLogin);
            panel1.Controls.Add(textBoxRegisterEmail);
            panel1.Controls.Add(buttonRegisterRegister);
            panel1.Controls.Add(textBoxRegisterPassword);
            panel1.Controls.Add(textBoxRegisterConfirm);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 434);
            panel1.TabIndex = 6;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Registration";
            Size = new Size(754, 434);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxRegisterEmail;
        private TextBox textBoxRegisterPassword;
        private TextBox textBoxRegisterConfirm;
        private Button buttonRegisterRegister;
        private Button buttonRegisterLogin;
        private Panel panel1;
    }
}
