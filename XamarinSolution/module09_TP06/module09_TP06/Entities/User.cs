using System;
using System.Collections.Generic;
using System.Text;

namespace module09_TP06.Entities
{
    public class User
{
		private String email;
		private String password;

        public String Email
		{
			get { return email; }
			set { email = value; }
		}

        public String Password
		{
			get { return password; }
			set { password = value; }
		}
	}
}
