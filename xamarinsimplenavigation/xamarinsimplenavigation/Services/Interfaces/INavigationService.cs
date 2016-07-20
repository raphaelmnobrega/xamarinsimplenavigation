using System.Threading.Tasks;

namespace xamarinsimplenavigation.Services.Interfaces
{
	public interface INavigationService
	{
		Task NavigateToLogin();
		Task NavigateToMainPage();
	}
}

