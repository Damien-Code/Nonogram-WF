namespace Nonogram_WF.Views
{
    partial class Difficulty
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
			buttonDifficultyPlayGame = new Button();
			buttonDifficultyHelp = new Button();
			numericUpDownDifficulty = new NumericUpDown();
			labelDifficulty = new Label();
			buttonDifficultyLogout = new Button();
			buttonDifficultyBack = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownDifficulty).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(buttonDifficultyPlayGame);
			panel1.Controls.Add(buttonDifficultyHelp);
			panel1.Controls.Add(numericUpDownDifficulty);
			panel1.Controls.Add(labelDifficulty);
			panel1.Controls.Add(buttonDifficultyLogout);
			panel1.Controls.Add(buttonDifficultyBack);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(2, 1, 2, 1);
			panel1.Name = "panel1";
			panel1.Size = new Size(754, 434);
			panel1.TabIndex = 0;
			// 
			// buttonDifficultyPlayGame
			// 
			buttonDifficultyPlayGame.Location = new Point(303, 282);
			buttonDifficultyPlayGame.Margin = new Padding(2, 1, 2, 1);
			buttonDifficultyPlayGame.Name = "buttonDifficultyPlayGame";
			buttonDifficultyPlayGame.Size = new Size(156, 57);
			buttonDifficultyPlayGame.TabIndex = 5;
			buttonDifficultyPlayGame.Text = "Play Game";
			buttonDifficultyPlayGame.UseVisualStyleBackColor = true;
			buttonDifficultyPlayGame.Click += buttonDifficultyPlayGame_Click;
			// 
			// buttonDifficultyHelp
			// 
			buttonDifficultyHelp.Location = new Point(447, 198);
			buttonDifficultyHelp.Margin = new Padding(2, 1, 2, 1);
			buttonDifficultyHelp.Name = "buttonDifficultyHelp";
			buttonDifficultyHelp.Size = new Size(50, 18);
			buttonDifficultyHelp.TabIndex = 4;
			buttonDifficultyHelp.Text = "Help";
			buttonDifficultyHelp.UseVisualStyleBackColor = true;
			buttonDifficultyHelp.Click += buttonDifficultyHelp_Click;
			// 
			// numericUpDownDifficulty
			// 
			numericUpDownDifficulty.Location = new Point(278, 199);
			numericUpDownDifficulty.Margin = new Padding(2, 1, 2, 1);
			numericUpDownDifficulty.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
			numericUpDownDifficulty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownDifficulty.Name = "numericUpDownDifficulty";
			numericUpDownDifficulty.Size = new Size(137, 23);
			numericUpDownDifficulty.TabIndex = 3;
			numericUpDownDifficulty.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownDifficulty.ValueChanged += numericUpDownDifficulty_ValueChanged;
			// 
			// labelDifficulty
			// 
			labelDifficulty.AutoSize = true;
			labelDifficulty.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelDifficulty.Location = new Point(292, 90);
			labelDifficulty.Margin = new Padding(2, 0, 2, 0);
			labelDifficulty.Name = "labelDifficulty";
			labelDifficulty.Size = new Size(171, 51);
			labelDifficulty.TabIndex = 2;
			labelDifficulty.Text = "Difficulty";
			// 
			// buttonDifficultyLogout
			// 
			buttonDifficultyLogout.Location = new Point(657, 17);
			buttonDifficultyLogout.Margin = new Padding(2, 1, 2, 1);
			buttonDifficultyLogout.Name = "buttonDifficultyLogout";
			buttonDifficultyLogout.Size = new Size(81, 22);
			buttonDifficultyLogout.TabIndex = 1;
			buttonDifficultyLogout.Text = "Logout";
			buttonDifficultyLogout.UseVisualStyleBackColor = true;
			buttonDifficultyLogout.Click += buttonDifficultyLogout_Click;
			// 
			// buttonDifficultyBack
			// 
			buttonDifficultyBack.Location = new Point(18, 17);
			buttonDifficultyBack.Margin = new Padding(2, 1, 2, 1);
			buttonDifficultyBack.Name = "buttonDifficultyBack";
			buttonDifficultyBack.Size = new Size(81, 22);
			buttonDifficultyBack.TabIndex = 0;
			buttonDifficultyBack.Text = "Back";
			buttonDifficultyBack.UseVisualStyleBackColor = true;
			buttonDifficultyBack.Click += buttonDifficultyBack_Click;
			// 
			// Difficulty
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Margin = new Padding(2, 1, 2, 1);
			Name = "Difficulty";
			Size = new Size(754, 434);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownDifficulty).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private Button buttonDifficultyLogout;
        private Button buttonDifficultyBack;
        private Button buttonDifficultyPlayGame;
        private Button buttonDifficultyHelp;
        private NumericUpDown numericUpDownDifficulty;
        private Label labelDifficulty;
    }
}
