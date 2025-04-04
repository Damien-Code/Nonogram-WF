namespace Nonogram_WF.Views
{
    partial class GameScreen
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
            buttonGameScreenSolve = new Button();
            buttonGameScreenBack = new Button();
            buttonGameScreenLogout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonGameScreenSolve);
            panel1.Controls.Add(buttonGameScreenBack);
            panel1.Controls.Add(buttonGameScreenLogout);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 475);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // buttonGameScreenSolve
            // 
            buttonGameScreenSolve.Location = new Point(70, 375);
            buttonGameScreenSolve.Margin = new Padding(2, 1, 2, 1);
            buttonGameScreenSolve.Name = "buttonGameScreenSolve";
            buttonGameScreenSolve.Size = new Size(118, 44);
            buttonGameScreenSolve.TabIndex = 3;
            buttonGameScreenSolve.Text = "Solve";
            buttonGameScreenSolve.UseVisualStyleBackColor = true;
            buttonGameScreenSolve.Click += buttonGameScreenSolve_Click;
            // 
            // buttonGameScreenBack
            // 
            buttonGameScreenBack.Location = new Point(20, 21);
            buttonGameScreenBack.Margin = new Padding(2, 1, 2, 1);
            buttonGameScreenBack.Name = "buttonGameScreenBack";
            buttonGameScreenBack.Size = new Size(81, 22);
            buttonGameScreenBack.TabIndex = 1;
            buttonGameScreenBack.Text = "Back";
            buttonGameScreenBack.UseVisualStyleBackColor = true;
            buttonGameScreenBack.Click += buttonGameScreenBack_Click;
            // 
            // buttonGameScreenLogout
            // 
            buttonGameScreenLogout.Location = new Point(655, 21);
            buttonGameScreenLogout.Margin = new Padding(2, 1, 2, 1);
            buttonGameScreenLogout.Name = "buttonGameScreenLogout";
            buttonGameScreenLogout.Size = new Size(81, 22);
            buttonGameScreenLogout.TabIndex = 0;
            buttonGameScreenLogout.Text = "Logout";
            buttonGameScreenLogout.UseVisualStyleBackColor = true;
            buttonGameScreenLogout.Click += buttonGameScreenLogout_Click;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "GameScreen";
            Size = new Size(800, 475);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonGameScreenLogout;
        private Button buttonGameScreenSolve;
        private Button buttonGameScreenBack;
    }
}
