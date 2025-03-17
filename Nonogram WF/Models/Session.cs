using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Database;

namespace Nonogram_WF.Models
{
    class Session
    {
		public static void SetSession(string email,Settings settings)
		{
			JSON_RW.SetSession(email, settings);
		}
		public static string GetSession() {
			return JSON_RW.GetSession();
		}
	}
}
