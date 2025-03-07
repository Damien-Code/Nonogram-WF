namespace Nonogram_WF
{
    partial class Welcome
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
            panelWelcome = new Panel();
            buttonWelcomeRegister = new Button();
            buttonWelcomeLogin = new Button();
            label1 = new Label();
            labelWelcome = new Label();
            panelWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // panelWelcome
            // 
            panelWelcome.Controls.Add(buttonWelcomeRegister);
            panelWelcome.Controls.Add(buttonWelcomeLogin);
            panelWelcome.Controls.Add(label1);
            panelWelcome.Controls.Add(labelWelcome);
            panelWelcome.Location = new Point(100, 85);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(1150, 700);
            panelWelcome.TabIndex = 0;
            // 
            // buttonWelcomeRegister
            // 
            buttonWelcomeRegister.Location = new Point(751, 482);
            buttonWelcomeRegister.Name = "buttonWelcomeRegister";
            buttonWelcomeRegister.Size = new Size(258, 90);
            buttonWelcomeRegister.TabIndex = 3;
            buttonWelcomeRegister.Text = "Don't have an account?";
            buttonWelcomeRegister.UseVisualStyleBackColor = true;
            buttonWelcomeRegister.Click += buttonWelcomeRegister_Click;
            // 
            // buttonWelcomeLogin
            // 
            buttonWelcomeLogin.Location = new Point(210, 482);
            buttonWelcomeLogin.Name = "buttonWelcomeLogin";
            buttonWelcomeLogin.Size = new Size(258, 90);
            buttonWelcomeLogin.TabIndex = 2;
            buttonWelcomeLogin.Text = "Login";
            buttonWelcomeLogin.UseVisualStyleBackColor = true;
            buttonWelcomeLogin.Click += buttonWelcomeLogin_Click;
            // 
            // label1
            // 
            label1.Location = new Point(210, 207);
            label1.Name = "label1";
            label1.Size = new Size(799, 166);
            label1.TabIndex = 1;
            label1.Text = "Thank you for downloading nonogram! To use our services you first have to create an account. Your account can track your scores,playtimes and settings.";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(381, 83);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(448, 107);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelWelcome);
            Name = "Welcome";
            Size = new Size(1400, 925);
            Load += Welcome_Load;
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelWelcome;
        private Label label1;
        private Label labelWelcome;
        private Button buttonWelcomeRegister;
        private Button buttonWelcomeLogin;
    }
}
