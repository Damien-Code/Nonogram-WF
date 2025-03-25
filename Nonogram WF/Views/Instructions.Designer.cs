namespace Nonogram_WF.Views
{
    partial class Instructions
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
            labelGameInstructions = new Label();
            buttonGameInstructions = new Button();
            panelInstructions = new Panel();
            panelInstructions.SuspendLayout();
            SuspendLayout();
            // 
            // labelGameInstructions
            // 
            labelGameInstructions.Location = new Point(244, 75);
            labelGameInstructions.Margin = new Padding(2, 0, 2, 0);
            labelGameInstructions.Name = "labelGameInstructions";
            labelGameInstructions.Size = new Size(283, 117);
            labelGameInstructions.TabIndex = 0;
            labelGameInstructions.Text = "What is a nonogram? How to play it.";
            // 
            // buttonGameInstructions
            // 
            buttonGameInstructions.Location = new Point(311, 284);
            buttonGameInstructions.Margin = new Padding(2, 1, 2, 1);
            buttonGameInstructions.Name = "buttonGameInstructions";
            buttonGameInstructions.Size = new Size(166, 44);
            buttonGameInstructions.TabIndex = 1;
            buttonGameInstructions.Text = "Continue";
            buttonGameInstructions.UseVisualStyleBackColor = true;
            buttonGameInstructions.VisibleChanged += buttonGameInstructions_VisibleChanged;
            buttonGameInstructions.Click += buttonGameInstructions_Click;
            // 
            // panelInstructions
            // 
            panelInstructions.Controls.Add(labelGameInstructions);
            panelInstructions.Controls.Add(buttonGameInstructions);
            panelInstructions.Dock = DockStyle.Fill;
            panelInstructions.Location = new Point(0, 0);
            panelInstructions.Margin = new Padding(2, 1, 2, 1);
            panelInstructions.Name = "panelInstructions";
            panelInstructions.Size = new Size(754, 434);
            panelInstructions.TabIndex = 2;
            // 
            // Instructions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelInstructions);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Instructions";
            Size = new Size(754, 434);
            panelInstructions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelGameInstructions;
        private Button buttonGameInstructions;
        private Panel panelInstructions;
    }
}
