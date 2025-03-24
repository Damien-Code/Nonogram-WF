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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // buttonHistoryBack
            // 
            buttonHistoryBack.Location = new Point(18, 15);
            buttonHistoryBack.Margin = new Padding(2, 1, 2, 1);
            buttonHistoryBack.Name = "buttonHistoryBack";
            buttonHistoryBack.Size = new Size(81, 22);
            buttonHistoryBack.TabIndex = 0;
            buttonHistoryBack.Text = "Back";
            buttonHistoryBack.UseVisualStyleBackColor = true;
            buttonHistoryBack.Click += buttonHistoryBack_Click;
            // 
            // buttonHistoryLogout
            // 
            buttonHistoryLogout.Location = new Point(658, 15);
            buttonHistoryLogout.Margin = new Padding(2, 1, 2, 1);
            buttonHistoryLogout.Name = "buttonHistoryLogout";
            buttonHistoryLogout.Size = new Size(81, 22);
            buttonHistoryLogout.TabIndex = 1;
            buttonHistoryLogout.Text = "Logout";
            buttonHistoryLogout.UseVisualStyleBackColor = true;
            buttonHistoryLogout.Click += buttonHistoryLogout_Click;
            // 
            // labelHistory
            // 
            labelHistory.AutoSize = true;
            labelHistory.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHistory.Location = new Point(316, 68);
            labelHistory.Margin = new Padding(2, 0, 2, 0);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(140, 51);
            labelHistory.TabIndex = 2;
            labelHistory.Text = "History";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(134, 139);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(501, 234);
            label1.TabIndex = 3;
            label1.Text = "Insert history table";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 434);
            panel1.TabIndex = 4;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(labelHistory);
            Controls.Add(buttonHistoryLogout);
            Controls.Add(buttonHistoryBack);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "History";
            Size = new Size(754, 434);
            VisibleChanged += History_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHistoryBack;
        private Button buttonHistoryLogout;
        private Label labelHistory;
        private Label label1;
        private Panel panel1;
    }
}
