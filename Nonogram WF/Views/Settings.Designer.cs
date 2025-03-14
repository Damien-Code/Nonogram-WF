namespace Nonogram_WF.Views
{
    partial class Settings
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
			buttonSettingsLogout = new Button();
			buttonSettingsBack = new Button();
			label1 = new Label();
			comboBoxSettingsTheme = new ComboBox();
			comboBoxSettingsFont = new ComboBox();
			SuspendLayout();
			// 
			// buttonSettingsLogout
			// 
			buttonSettingsLogout.Location = new Point(656, 14);
			buttonSettingsLogout.Margin = new Padding(1, 1, 1, 1);
			buttonSettingsLogout.Name = "buttonSettingsLogout";
			buttonSettingsLogout.Size = new Size(80, 22);
			buttonSettingsLogout.TabIndex = 0;
			buttonSettingsLogout.Text = "Logout";
			buttonSettingsLogout.UseVisualStyleBackColor = true;
			buttonSettingsLogout.Click += buttonSettingsLogout_Click;
			// 
			// buttonSettingsBack
			// 
			buttonSettingsBack.Location = new Point(14, 14);
			buttonSettingsBack.Margin = new Padding(1, 1, 1, 1);
			buttonSettingsBack.Name = "buttonSettingsBack";
			buttonSettingsBack.Size = new Size(80, 22);
			buttonSettingsBack.TabIndex = 1;
			buttonSettingsBack.Text = "Back";
			buttonSettingsBack.UseVisualStyleBackColor = true;
			buttonSettingsBack.Click += buttonSettingsBack_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(272, 97);
			label1.Margin = new Padding(1, 0, 1, 0);
			label1.Name = "label1";
			label1.Size = new Size(157, 51);
			label1.TabIndex = 2;
			label1.Text = "Settings";
			// 
			// comboBoxSettingsTheme
			// 
			comboBoxSettingsTheme.FormattingEnabled = true;
			comboBoxSettingsTheme.Items.AddRange(new object[] { "Light", "Dark" });
			comboBoxSettingsTheme.Location = new Point(253, 197);
			comboBoxSettingsTheme.Margin = new Padding(1, 1, 1, 1);
			comboBoxSettingsTheme.Name = "comboBoxSettingsTheme";
			comboBoxSettingsTheme.Size = new Size(196, 23);
			comboBoxSettingsTheme.TabIndex = 3;
			comboBoxSettingsTheme.Text = "Theme:";
			comboBoxSettingsTheme.SelectedIndexChanged += comboBoxSettingsTheme_SelectedIndexChanged;
			// 
			// comboBoxSettingsFont
			// 
			comboBoxSettingsFont.FormattingEnabled = true;
			comboBoxSettingsFont.Location = new Point(253, 242);
			comboBoxSettingsFont.Margin = new Padding(1, 1, 1, 1);
			comboBoxSettingsFont.Name = "comboBoxSettingsFont";
			comboBoxSettingsFont.Size = new Size(196, 23);
			comboBoxSettingsFont.TabIndex = 4;
			comboBoxSettingsFont.Text = "Font size:";
			// 
			// Settings
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(comboBoxSettingsFont);
			Controls.Add(comboBoxSettingsTheme);
			Controls.Add(label1);
			Controls.Add(buttonSettingsBack);
			Controls.Add(buttonSettingsLogout);
			Margin = new Padding(1, 1, 1, 1);
			Name = "Settings";
			Size = new Size(754, 434);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonSettingsLogout;
        private Button buttonSettingsBack;
        private Label label1;
        private ComboBox comboBoxSettingsTheme;
        private ComboBox comboBoxSettingsFont;
    }
}
