using System.CodeDom;

namespace Nonogram_WF
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            //this.MinimumSize = new Size(900, 450);
            
            
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void welcome2_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Top + Screen.PrimaryScreen.WorkingArea.Height) / 4;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Left + Screen.PrimaryScreen.WorkingArea.Width) / 4;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}


