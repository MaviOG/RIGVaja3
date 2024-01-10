namespace RIGProjeck.Class
{
	public class User
	{
		private int userid { get; set; }
		private string username { get; set; }
		private string password { get; set; }
		private string email { get; set; }
		private bool verified { get; set; }

		private List<User> users { get; set; }

		public List<Nepremičnina> uporabnikoveObjave { get; set; }

		public User(int userid,string username, string password, string email, bool verified)
		{
			this.userid = userid;
			this.username = username;
			this.password = password;
			this.email = email;
			this.verified = verified;
		}
		public bool Register(string Username, string Password, string Email)
		{
			int id = users.Count+1;
			password = Password;
			username = Username;
			email = Email;
			foreach (var user in users)
			{
				if (username == user.username || email == user.email)
				{
					return false;
				}
				users.Add(new User(id,username, password, email, false));

			}
			return true;
		}

		public bool LogIn(string password, string username)
		{
			foreach (var user in users)
			{
				if (user.username == username && user.password == password) 
				{
					return true;
				}
			}
			return false;
		}
		public void LogOut()
		{
			//iz vmesnika se prestavi na login/register stran
			throw new System.NotImplementedException("Not implemented");
		}

		public void VerifyUser(User selectedUser)
		{
			if (users.Count != 0 && users != null)
			{
				users.Find(p => p.userid == selectedUser.userid).verified = true;
			}

		}
	}
}
