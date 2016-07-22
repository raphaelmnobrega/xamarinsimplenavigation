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
			this.navigationService = DependencyService.Get<INavigationService>();
		}

		private ICommand loginCommand;
		public ICommand LoginCommand
		{
			get
			{
				return loginCommand ?? (loginCommand = new Command(() =>
				{
					navigationService.NavigateToLogin();
					//navigationService.NavigateToMainPage();
				}));                                                  
			}

		}
	}
}

