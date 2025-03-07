using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram_WF
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void buttonWelcomeLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Show();
        }

        private void buttonWelcomeRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
