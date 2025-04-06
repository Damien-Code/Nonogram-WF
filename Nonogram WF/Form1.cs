using System.CodeDom;
using System.Runtime.InteropServices;

namespace Nonogram_WF
{

    public partial class Form1 : Form
    {
        public Form1()

        { 
            InitializeComponent();
            // Positions the form to the centre of the users screen
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void welcome2_Load(object sender, EventArgs e)
        {
            //removes ability to resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}


