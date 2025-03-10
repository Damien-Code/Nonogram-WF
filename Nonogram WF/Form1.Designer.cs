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
            login1 = new login();
            welcome2 = new Welcome();
            Instructions = new Views.Instructions();
            SuspendLayout();
            // 
            // login1
            // 
            login1.Dock = DockStyle.Fill;
            login1.Location = new Point(0, 0);
            login1.Margin = new Padding(4);
            login1.Name = "login1";
            login1.Size = new Size(1489, 934);
            login1.TabIndex = 0;
            login1.Visible = false;
            // 
            // welcome2
            // 
            welcome2.BackColor = Color.White;
            welcome2.Dock = DockStyle.Fill;
            welcome2.Location = new Point(0, 0);
            welcome2.Name = "welcome2";
            welcome2.Size = new Size(1489, 934);
            welcome2.TabIndex = 0;
            // 
            // Instructions
            // 
            Instructions.Location = new Point(0, 0);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(2754, 1718);
            Instructions.TabIndex = 1;
            Instructions.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 934);
            Controls.Add(Instructions);
            Controls.Add(login1);
            Controls.Add(welcome2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private login login1;
        private Welcome welcome2;
        private Views.Instructions Instructions;
    }

}
