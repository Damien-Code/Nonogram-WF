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
            SuspendLayout();
            // 
            // labelGameInstructions
            // 
            labelGameInstructions.Location = new Point(435, 174);
            labelGameInstructions.Name = "labelGameInstructions";
            labelGameInstructions.Size = new Size(525, 249);
            labelGameInstructions.TabIndex = 0;
            labelGameInstructions.Text = "What is a nonogram? How to play it.";
            // 
            // buttonGameInstructions
            // 
            buttonGameInstructions.Location = new Point(539, 609);
            buttonGameInstructions.Name = "buttonGameInstructions";
            buttonGameInstructions.Size = new Size(308, 94);
            buttonGameInstructions.TabIndex = 1;
            buttonGameInstructions.Text = "Continue";
            buttonGameInstructions.UseVisualStyleBackColor = true;
            // 
            // Instructions
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonGameInstructions);
            Controls.Add(labelGameInstructions);
            Name = "Instructions";
            Size = new Size(1377, 859);
            ResumeLayout(false);
        }

        #endregion

        private Label labelGameInstructions;
        private Button buttonGameInstructions;
    }
}
