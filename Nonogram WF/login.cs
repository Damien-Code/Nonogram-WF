using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram_WF
{
	public partial class login : UserControl
	{
		public login()
		{
			InitializeComponent();
			//this.Dock = DockStyle.Fill;
		}

		private void login_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			//add login func

		}
		private void buttonLoginRegister_Click(object sender, EventArgs e)
		{
			this.Hide();
			//add reg func

		}
	}
}
