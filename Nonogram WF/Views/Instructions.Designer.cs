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
            labelGameInstructions.Location = new Point(454, 159);
            labelGameInstructions.Name = "labelGameInstructions";
            labelGameInstructions.Size = new Size(525, 249);
            labelGameInstructions.TabIndex = 0;
            labelGameInstructions.Text = "What is a nonogram? How to play it.";
            // 
            // buttonGameInstructions
            // 
            buttonGameInstructions.Location = new Point(578, 606);
            buttonGameInstructions.Name = "buttonGameInstructions";
            buttonGameInstructions.Size = new Size(308, 94);
            buttonGameInstructions.TabIndex = 1;
            buttonGameInstructions.Text = "Continue";
            buttonGameInstructions.UseVisualStyleBackColor = true;
            buttonGameInstructions.Click += buttonGameInstructions_Click;
            // 
            // panelInstructions
            // 
            panelInstructions.Controls.Add(labelGameInstructions);
            panelInstructions.Controls.Add(buttonGameInstructions);
            panelInstructions.Dock = DockStyle.Fill;
            panelInstructions.Location = new Point(0, 0);
            panelInstructions.Name = "panelInstructions";
            panelInstructions.Size = new Size(1400, 925);
            panelInstructions.TabIndex = 2;
            // 
            // Instructions
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelInstructions);
            Name = "Instructions";
            Size = new Size(1400, 925);
            panelInstructions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelGameInstructions;
        private Button buttonGameInstructions;
        private Panel panelInstructions;
    }
}
