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
            buttonSettingsLogout.Location = new Point(1141, 46);
            buttonSettingsLogout.Name = "buttonSettingsLogout";
            buttonSettingsLogout.Size = new Size(150, 46);
            buttonSettingsLogout.TabIndex = 0;
            buttonSettingsLogout.Text = "Logout";
            buttonSettingsLogout.UseVisualStyleBackColor = true;
            buttonSettingsLogout.Click += buttonSettingsLogout_Click;
            // 
            // buttonSettingsBack
            // 
            buttonSettingsBack.Location = new Point(34, 46);
            buttonSettingsBack.Name = "buttonSettingsBack";
            buttonSettingsBack.Size = new Size(150, 46);
            buttonSettingsBack.TabIndex = 1;
            buttonSettingsBack.Text = "Back";
            buttonSettingsBack.UseVisualStyleBackColor = true;
            buttonSettingsBack.Click += buttonSettingsBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(505, 208);
            label1.Name = "label1";
            label1.Size = new Size(307, 100);
            label1.TabIndex = 2;
            label1.Text = "Settings";
            // 
            // comboBoxSettingsTheme
            // 
            comboBoxSettingsTheme.FormattingEnabled = true;
            comboBoxSettingsTheme.Location = new Point(471, 420);
            comboBoxSettingsTheme.Name = "comboBoxSettingsTheme";
            comboBoxSettingsTheme.Size = new Size(362, 40);
            comboBoxSettingsTheme.TabIndex = 3;
            comboBoxSettingsTheme.Text = "Theme:";
            // 
            // comboBoxSettingsFont
            // 
            comboBoxSettingsFont.FormattingEnabled = true;
            comboBoxSettingsFont.Location = new Point(471, 517);
            comboBoxSettingsFont.Name = "comboBoxSettingsFont";
            comboBoxSettingsFont.Size = new Size(362, 40);
            comboBoxSettingsFont.TabIndex = 4;
            comboBoxSettingsFont.Text = "Font size:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxSettingsFont);
            Controls.Add(comboBoxSettingsTheme);
            Controls.Add(label1);
            Controls.Add(buttonSettingsBack);
            Controls.Add(buttonSettingsLogout);
            Name = "Settings";
            Size = new Size(1337, 882);
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
