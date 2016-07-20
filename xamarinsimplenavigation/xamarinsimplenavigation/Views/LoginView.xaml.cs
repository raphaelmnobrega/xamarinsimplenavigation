using xamarinsimplenavigation.ViewModels;
using Xamarin.Forms;

namespace xamarinsimplenavigation.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            //InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}
