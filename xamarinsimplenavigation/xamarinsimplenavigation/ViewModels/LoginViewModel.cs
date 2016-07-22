using System;
using System.Windows.Input;
using Xamarin.Forms;
using xamarinsimplenavigation.Services.Interfaces;
using xamarinsimplenavigation.ViewModels.Base;
using xamarinsimplenavigation.ViewModels.Entities;

namespace xamarinsimplenavigation
{
	public class LoginViewModel : TypedViewModelBase<User>
	{
		private readonly INavigationService navigationService;

		public LoginViewModel()
		{
			this.navigationService = DependencyService.Get<INavigationService>();
		}

		private ICommand signInCommand;
		public ICommand SignInCommand
		{
			get
			{
				return signInCommand ?? (signInCommand = new Command(() =>
				{
					navigationService.NavigateToMainPage();
				}));
			}

		}

	}
}

