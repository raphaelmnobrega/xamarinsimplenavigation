using System.Threading.Tasks;
using xamarinsimplenavigation.Services.Interfaces;
using xamarinsimplenavigation.Views;

namespace xamarinsimplenavigation.Services
{
	public class NavigationService : INavigationService
	{

		public async Task NavigateToLogin()
		{
            await App.Current.MainPage.Navigation.PushAsync(new LoginView());
		}

		public async Task NavigateToMainPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new MainPageView());
		}

        
	}
}

