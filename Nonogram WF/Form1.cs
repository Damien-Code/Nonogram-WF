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

        }

		//[DllImport("kernel32.dll", SetLastError = true)]
       // [return: MarshalAs(UnmanagedType.Bool)]
       // static extern bool AllocConsole();
	//}


        private void Form1_Load(object sender, EventArgs e)
        {
            // Sets the height and width to half the users screensize
            // We had a lot of issues with form size because of the differences in DPI
            // This seemed to fix the issue on both of our machines
            this.Width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height / 2;
            // Positions the form to the centre of the users screen
            this.Top = (Screen.PrimaryScreen.WorkingArea.Top + Screen.PrimaryScreen.WorkingArea.Height) / 4;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Left + Screen.PrimaryScreen.WorkingArea.Width) / 4;
            // Don't allow resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}


