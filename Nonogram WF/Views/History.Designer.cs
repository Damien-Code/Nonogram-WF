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
            buttonHistoryBack.Location = new Point(26, 30);
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
            buttonHistoryLogout.Location = new Point(1218, 30);
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
            labelHistory.Location = new Point(581, 152);
            labelHistory.Margin = new Padding(4, 0, 4, 0);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(276, 100);
            labelHistory.TabIndex = 2;
            labelHistory.Text = "History";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Level, HintsUsed, UsedSolver, TimeColumn });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(316, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(803, 459);
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
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(labelHistory);
            panel1.Controls.Add(buttonHistoryBack);
            panel1.Controls.Add(buttonHistoryLogout);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 926);
            panel1.TabIndex = 4;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "History";
            Size = new Size(1400, 926);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewTextBoxColumn HintsUsed;
        private DataGridViewTextBoxColumn UsedSolver;
        private DataGridViewTextBoxColumn TimeColumn;
        private Panel panel1;
        private Label label1;
        private Panel panel1;
    }
}
