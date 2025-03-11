namespace Nonogram_WF.Views
{
    partial class History
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
            buttonHistoryBack = new Button();
            buttonHistoryLogout = new Button();
            labelHistory = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonHistoryBack
            // 
            buttonHistoryBack.Location = new Point(33, 32);
            buttonHistoryBack.Name = "buttonHistoryBack";
            buttonHistoryBack.Size = new Size(150, 46);
            buttonHistoryBack.TabIndex = 0;
            buttonHistoryBack.Text = "Back";
            buttonHistoryBack.UseVisualStyleBackColor = true;
            buttonHistoryBack.Click += buttonHistoryBack_Click;
            // 
            // buttonHistoryLogout
            // 
            buttonHistoryLogout.Location = new Point(1222, 32);
            buttonHistoryLogout.Name = "buttonHistoryLogout";
            buttonHistoryLogout.Size = new Size(150, 46);
            buttonHistoryLogout.TabIndex = 1;
            buttonHistoryLogout.Text = "Logout";
            buttonHistoryLogout.UseVisualStyleBackColor = true;
            // 
            // labelHistory
            // 
            labelHistory.AutoSize = true;
            labelHistory.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHistory.Location = new Point(587, 145);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(276, 100);
            labelHistory.TabIndex = 2;
            labelHistory.Text = "History";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(249, 296);
            label1.Name = "label1";
            label1.Size = new Size(931, 500);
            label1.TabIndex = 3;
            label1.Text = "Insert history table";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(labelHistory);
            Controls.Add(buttonHistoryLogout);
            Controls.Add(buttonHistoryBack);
            Name = "History";
            Size = new Size(1400, 925);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHistoryBack;
        private Button buttonHistoryLogout;
        private Label labelHistory;
        private Label label1;
    }
}
