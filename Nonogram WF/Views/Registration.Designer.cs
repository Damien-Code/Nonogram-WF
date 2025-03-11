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
            label1.Location = new Point(642, 91);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(308, 100);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // textBoxRegisterEmail
            // 
            textBoxRegisterEmail.Location = new Point(576, 338);
            textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            textBoxRegisterEmail.Size = new Size(476, 39);
            textBoxRegisterEmail.TabIndex = 1;
            textBoxRegisterEmail.Text = "Email:";
            // 
            // textBoxRegisterPassword
            // 
            textBoxRegisterPassword.Location = new Point(576, 449);
            textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            textBoxRegisterPassword.Size = new Size(476, 39);
            textBoxRegisterPassword.TabIndex = 2;
            textBoxRegisterPassword.Text = "Password:";
            // 
            // textBoxRegisterConfirm
            // 
            textBoxRegisterConfirm.Location = new Point(576, 565);
            textBoxRegisterConfirm.Name = "textBoxRegisterConfirm";
            textBoxRegisterConfirm.Size = new Size(476, 39);
            textBoxRegisterConfirm.TabIndex = 3;
            textBoxRegisterConfirm.Text = "Confirm Password:";
            // 
            // buttonRegisterRegister
            // 
            buttonRegisterRegister.Location = new Point(311, 747);
            buttonRegisterRegister.Margin = new Padding(0);
            buttonRegisterRegister.Name = "buttonRegisterRegister";
            buttonRegisterRegister.Size = new Size(258, 90);
            buttonRegisterRegister.TabIndex = 4;
            buttonRegisterRegister.Text = "Register";
            buttonRegisterRegister.UseVisualStyleBackColor = true;
            buttonRegisterRegister.Click += buttonRegisterRegister_Click;
            // 
            // buttonRegisterLogin
            // 
            buttonRegisterLogin.Location = new Point(1052, 747);
            buttonRegisterLogin.Margin = new Padding(0);
            buttonRegisterLogin.Name = "buttonRegisterLogin";
            buttonRegisterLogin.Size = new Size(258, 90);
            buttonRegisterLogin.TabIndex = 5;
            buttonRegisterLogin.Text = "Login";
            buttonRegisterLogin.UseVisualStyleBackColor = true;
            buttonRegisterLogin.Click += buttonRegisterLogin_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonRegisterLogin);
            panel1.Controls.Add(textBoxRegisterEmail);
            panel1.Controls.Add(buttonRegisterRegister);
            panel1.Controls.Add(textBoxRegisterPassword);
            panel1.Controls.Add(textBoxRegisterConfirm);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1694, 1035);
            panel1.TabIndex = 6;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Registration";
            Size = new Size(1694, 1035);
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
