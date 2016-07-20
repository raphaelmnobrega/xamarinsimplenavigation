using xamarinsimplenavigation.ViewModels.Base;

namespace xamarinsimplenavigation.ViewModels.Entities
{
	public class User : ViewModelBase
	{
		private string login;

		public string Login
		{
			get
			{
				return login;
			}

			set
			{
				login = value;
				RaisedPropertyChanged(() => Login);
			}
		}

		private string password;

		public string Password
		{
			get
			{
				return password;
			}

			set
			{
				password = value;
				RaisedPropertyChanged(() => Password);
			}
		}
	}
}

