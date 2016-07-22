using xamarinsimplenavigation.Services;
using xamarinsimplenavigation.Services.Interfaces;
using xamarinsimplenavigation.Views;
using Xamarin.Forms;

namespace xamarinsimplenavigation
{
    public class App : Application
    {
        public App()
        {
            DependencyService.Register<INavigationService, NavigationService>();
            // The root page of your application
            MainPage = new NavigationPage(new StartPageView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
