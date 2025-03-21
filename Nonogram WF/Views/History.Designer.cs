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
            dataGridView1 = new DataGridView();
            Level = new DataGridViewTextBoxColumn();
            HintsUsed = new DataGridViewTextBoxColumn();
            UsedSolver = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonHistoryBack
            // 
            buttonHistoryBack.Location = new Point(33, 32);
            buttonHistoryBack.Margin = new Padding(4, 2, 4, 2);
            buttonHistoryBack.Name = "buttonHistoryBack";
            buttonHistoryBack.Size = new Size(150, 47);
            buttonHistoryBack.TabIndex = 0;
            buttonHistoryBack.Text = "Back";
            buttonHistoryBack.UseVisualStyleBackColor = true;
            buttonHistoryBack.Click += buttonHistoryBack_Click;
            // 
            // buttonHistoryLogout
            // 
            buttonHistoryLogout.Location = new Point(1222, 32);
            buttonHistoryLogout.Margin = new Padding(4, 2, 4, 2);
            buttonHistoryLogout.Name = "buttonHistoryLogout";
            buttonHistoryLogout.Size = new Size(150, 47);
            buttonHistoryLogout.TabIndex = 1;
            buttonHistoryLogout.Text = "Logout";
            buttonHistoryLogout.UseVisualStyleBackColor = true;
            buttonHistoryLogout.Click += buttonHistoryLogout_Click;
            // 
            // labelHistory
            // 
            labelHistory.AutoSize = true;
            labelHistory.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHistory.Location = new Point(587, 145);
            labelHistory.Margin = new Padding(4, 0, 4, 0);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(276, 100);
            labelHistory.TabIndex = 2;
            labelHistory.Text = "History";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Level, HintsUsed, UsedSolver, TimeColumn });
            dataGridView1.Location = new Point(277, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(884, 459);
            dataGridView1.TabIndex = 3;
            // 
            // Level
            // 
            Level.HeaderText = "Level";
            Level.MinimumWidth = 10;
            Level.Name = "Level";
            Level.Width = 200;
            // 
            // HintsUsed
            // 
            HintsUsed.HeaderText = "Hints used";
            HintsUsed.MinimumWidth = 10;
            HintsUsed.Name = "HintsUsed";
            HintsUsed.Width = 200;
            // 
            // UsedSolver
            // 
            UsedSolver.HeaderText = "Used solver";
            UsedSolver.MinimumWidth = 10;
            UsedSolver.Name = "UsedSolver";
            UsedSolver.Width = 200;
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "Total play time";
            TimeColumn.MinimumWidth = 10;
            TimeColumn.Name = "TimeColumn";
            TimeColumn.Width = 200;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(labelHistory);
            Controls.Add(buttonHistoryLogout);
            Controls.Add(buttonHistoryBack);
            Margin = new Padding(4, 2, 4, 2);
            Name = "History";
            Size = new Size(1400, 926);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHistoryBack;
        private Button buttonHistoryLogout;
        private Label labelHistory;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewTextBoxColumn HintsUsed;
        private DataGridViewTextBoxColumn UsedSolver;
        private DataGridViewTextBoxColumn TimeColumn;
    }
}
