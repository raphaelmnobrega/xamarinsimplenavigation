using System.Windows.Input;
using xamarinsimplenavigation.Services.Interfaces;
using xamarinsimplenavigation.ViewModels.Base;
using Xamarin.Forms;

namespace xamarinsimplenavigation.ViewModels
{
	public class StartPageViewModel : ViewModelBase
	{
		private readonly INavigationService navigationService;

		public StartPageViewModel()
		{
			//this.EmailLoginCommand = new Command(this.EmailLogin);
			this.navigationService = DependencyService.Get<INavigationService>();
		}

		private ICommand emailLoginCommand;
		public ICommand EmailLoginCommand
		{
			get
			{
				return emailLoginCommand ?? (emailLoginCommand = new Command(() =>
				{
					navigationService.NavigateToLogin();
				}));                                                  
			}

		}

		//private void EmailLogin()
		//{
		//	navigationService.NavigateToLogin();			
		//}

	}
}

