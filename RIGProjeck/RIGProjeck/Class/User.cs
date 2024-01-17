
using System.ComponentModel.DataAnnotations;
namespace RIGProjeck.Class
{
	public class User
	{
		NepremicninaDB usersDb = new NepremicninaDB();
		
		[Key] public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool verified { get; set; }
		

		public List<Nepremičnina> uporabnikoveObjave { get; set; }

		public User(int Id, string username, string password, string email, bool verified)
		{
			this.Id = Id;
			this.username = username;
			this.password = password;
			this.email = email;
			this.verified = false;
		}

        public User()
        {
        }

        public bool Register(string Username, string Password, string Email)
		{
			int usersCount = usersDb.Users.Count();
			int id = usersCount+1;
			password = Password;
			username = Username;
			email = Email;
			foreach (var user in usersDb.Users)
			{
				if (username == user.username || email == user.email)
				{
					return false;
				}
				usersDb.Users.Add(new User(id,username, password, email, false));

			}
			return true;
		}

		public bool LogIn(string password, string username)
		{
			foreach (var user in usersDb.Users)
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
			if (usersDb.Users != null)
			{
				usersDb.Users.FirstOrDefault(p => p.Id == selectedUser.Id).verified = true;
				
			}

		}
	}
}
