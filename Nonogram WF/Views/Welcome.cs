using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nonogram_WF.Controllers;
using Nonogram_WF.Database;
using Nonogram_WF.Models;

namespace Nonogram_WF.Views
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

			// finds the form where the control is on.
			// searches all the controls with the given name.
			// shows the first control that is found.
			FindForm().Controls.Find("login1", false).First().Show();
		}

		private void buttonWelcomeRegister_Click(object sender, EventArgs e)
		{
			this.Hide();
			FindForm().Controls.Find("Registration", false).First().Show();
		}

		/// <summary>
		/// Checks if a session exist, if so it will redirect the user to Home
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Welcome_Load(object sender, EventArgs e)
		{
			if (HasSession())
            {
                this.Hide();
                FindForm().Controls.Find("Home", false).First().Show();

            }
		}

		/// <summary>
		/// Checks if email is set, if so then it'll return true, else false
		/// </summary>
		/// <returns>bool</returns>
		private bool HasSession()
		{
			Users user = Controllers.SessionController.GetSession();
			return (user.Email == null) ? false : (user.Email == "") ? false : true;
		}

		private void panelWelcome_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
