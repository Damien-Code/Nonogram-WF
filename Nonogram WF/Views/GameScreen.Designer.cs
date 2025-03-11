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
            buttonGameScreenHint = new Button();
            buttonGameScreenSolve = new Button();
            label1 = new Label();
            buttonGameScreenBack = new Button();
            buttonGameScreenLogout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonGameScreenHint);
            panel1.Controls.Add(buttonGameScreenSolve);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonGameScreenBack);
            panel1.Controls.Add(buttonGameScreenLogout);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 925);
            panel1.TabIndex = 0;
            // 
            // buttonGameScreenHint
            // 
            buttonGameScreenHint.Location = new Point(748, 801);
            buttonGameScreenHint.Name = "buttonGameScreenHint";
            buttonGameScreenHint.Size = new Size(220, 94);
            buttonGameScreenHint.TabIndex = 4;
            buttonGameScreenHint.Text = "Hint";
            buttonGameScreenHint.UseVisualStyleBackColor = true;
            // 
            // buttonGameScreenSolve
            // 
            buttonGameScreenSolve.Location = new Point(130, 801);
            buttonGameScreenSolve.Name = "buttonGameScreenSolve";
            buttonGameScreenSolve.Size = new Size(220, 94);
            buttonGameScreenSolve.TabIndex = 3;
            buttonGameScreenSolve.Text = "Solve";
            buttonGameScreenSolve.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(468, 191);
            label1.Name = "label1";
            label1.Size = new Size(500, 500);
            label1.TabIndex = 2;
            label1.Text = "Insert grid";
            // 
            // buttonGameScreenBack
            // 
            buttonGameScreenBack.Location = new Point(37, 44);
            buttonGameScreenBack.Name = "buttonGameScreenBack";
            buttonGameScreenBack.Size = new Size(150, 46);
            buttonGameScreenBack.TabIndex = 1;
            buttonGameScreenBack.Text = "Back";
            buttonGameScreenBack.UseVisualStyleBackColor = true;
            buttonGameScreenBack.Click += buttonGameScreenBack_Click;
            // 
            // buttonGameScreenLogout
            // 
            buttonGameScreenLogout.Location = new Point(1216, 44);
            buttonGameScreenLogout.Name = "buttonGameScreenLogout";
            buttonGameScreenLogout.Size = new Size(150, 46);
            buttonGameScreenLogout.TabIndex = 0;
            buttonGameScreenLogout.Text = "Logout";
            buttonGameScreenLogout.UseVisualStyleBackColor = true;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "GameScreen";
            Size = new Size(1400, 925);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonGameScreenLogout;
        private Button buttonGameScreenHint;
        private Button buttonGameScreenSolve;
        private Label label1;
        private Button buttonGameScreenBack;
    }
}
