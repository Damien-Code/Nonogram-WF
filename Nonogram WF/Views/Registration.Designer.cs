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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(505, 40);
            label1.Name = "label1";
            label1.Size = new Size(308, 100);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // textBoxRegisterEmail
            // 
            textBoxRegisterEmail.Location = new Point(415, 273);
            textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            textBoxRegisterEmail.Size = new Size(476, 39);
            textBoxRegisterEmail.TabIndex = 1;
            textBoxRegisterEmail.Text = "Email:";
            // 
            // textBoxRegisterPassword
            // 
            textBoxRegisterPassword.Location = new Point(415, 424);
            textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            textBoxRegisterPassword.Size = new Size(476, 39);
            textBoxRegisterPassword.TabIndex = 2;
            textBoxRegisterPassword.Text = "Password:";
            // 
            // textBoxRegisterConfirm
            // 
            textBoxRegisterConfirm.Location = new Point(415, 570);
            textBoxRegisterConfirm.Name = "textBoxRegisterConfirm";
            textBoxRegisterConfirm.Size = new Size(476, 39);
            textBoxRegisterConfirm.TabIndex = 3;
            textBoxRegisterConfirm.Text = "Confirm Password:";
            // 
            // buttonRegisterRegister
            // 
            buttonRegisterRegister.Location = new Point(415, 688);
            buttonRegisterRegister.Name = "buttonRegisterRegister";
            buttonRegisterRegister.Size = new Size(278, 76);
            buttonRegisterRegister.TabIndex = 4;
            buttonRegisterRegister.Text = "Register";
            buttonRegisterRegister.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterLogin
            // 
            buttonRegisterLogin.Location = new Point(758, 688);
            buttonRegisterLogin.Name = "buttonRegisterLogin";
            buttonRegisterLogin.Size = new Size(133, 76);
            buttonRegisterLogin.TabIndex = 5;
            buttonRegisterLogin.Text = "Login";
            buttonRegisterLogin.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRegisterLogin);
            Controls.Add(buttonRegisterRegister);
            Controls.Add(textBoxRegisterConfirm);
            Controls.Add(textBoxRegisterPassword);
            Controls.Add(textBoxRegisterEmail);
            Controls.Add(label1);
            Name = "Registration";
            Size = new Size(1344, 916);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxRegisterEmail;
        private TextBox textBoxRegisterPassword;
        private TextBox textBoxRegisterConfirm;
        private Button buttonRegisterRegister;
        private Button buttonRegisterLogin;
    }
}
