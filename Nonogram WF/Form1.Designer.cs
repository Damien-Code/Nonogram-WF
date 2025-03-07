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
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            welcome2 = new Welcome();
            SuspendLayout();
            // 
            // welcome2
            // 
            welcome2.BackColor = Color.White;
            welcome2.Dock = DockStyle.Fill;
            welcome2.Location = new Point(0, 0);
            welcome2.Name = "welcome2";
            welcome2.Size = new Size(1374, 854);
            welcome2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 854);
            Controls.Add(welcome2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Welcome welcome1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Welcome welcome2;
    }
}
