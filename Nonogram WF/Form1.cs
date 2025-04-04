using System.CodeDom;
using System.Runtime.InteropServices;

namespace Nonogram_WF
{

    public partial class Form1 : Form
    {
        public Form1()

        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void welcome2_Load(object sender, EventArgs e)
        {
            //AllocConsole();
            
            // Positions the form to the centre of the users screen
            this.Top = (Screen.PrimaryScreen.WorkingArea.Top + Screen.PrimaryScreen.WorkingArea.Height) / 4;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Left + Screen.PrimaryScreen.WorkingArea.Width) / 4;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}


