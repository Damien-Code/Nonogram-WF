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
            Registration = new Views.Registration();
            SuspendLayout();
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
            Controls.Add(Registration);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Views.Welcome Welcome;
        private Views.Instructions Instructions;
        private Views.Home Home;
        private Views.Difficulty Difficulty;
        private Views.GameScreen GameScreen;
        private Views.Settings Settings;
        private Views.Registration Registration;
        private Views.Login Login;
        private Views.History history1;
    }

}
