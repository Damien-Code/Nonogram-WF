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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonHistoryBack = new Button();
            buttonHistoryLogout = new Button();
            labelHistory = new Label();
            dataGridView1 = new DataGridView();
            Level = new DataGridViewTextBoxColumn();
            HintsUsed = new DataGridViewTextBoxColumn();
            UsedSolver = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHistoryBack
            // 
            buttonHistoryBack.Location = new Point(14, 14);
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
            buttonHistoryLogout.Location = new Point(656, 14);
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
            labelHistory.Location = new Point(313, 71);
            labelHistory.Margin = new Padding(2, 0, 2, 0);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(140, 51);
            labelHistory.TabIndex = 2;
            labelHistory.Text = "History";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Level, HintsUsed, UsedSolver, TimeColumn });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(170, 151);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(432, 215);
            dataGridView1.TabIndex = 3;
            // 
            // Level
            // 
            Level.HeaderText = "Level";
            Level.MinimumWidth = 10;
            Level.Name = "Level";
            Level.ReadOnly = true;
            Level.Width = 200;
            // 
            // HintsUsed
            // 
            HintsUsed.HeaderText = "Hints used";
            HintsUsed.MinimumWidth = 10;
            HintsUsed.Name = "HintsUsed";
            HintsUsed.ReadOnly = true;
            HintsUsed.Width = 200;
            // 
            // UsedSolver
            // 
            UsedSolver.HeaderText = "Used solver";
            UsedSolver.MinimumWidth = 10;
            UsedSolver.Name = "UsedSolver";
            UsedSolver.ReadOnly = true;
            UsedSolver.Width = 200;
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "Total play time";
            TimeColumn.MinimumWidth = 10;
            TimeColumn.Name = "TimeColumn";
            TimeColumn.ReadOnly = true;
            TimeColumn.Width = 200;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 475);
            panel1.TabIndex = 4;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHistory);
            Controls.Add(buttonHistoryLogout);
            Controls.Add(buttonHistoryBack);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "History";
            Size = new Size(800, 475);
            Load += History_Load;
            VisibleChanged += History_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        
    }
}
