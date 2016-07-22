using Xamarin.Forms;
using xamarinsimplenavigation.ViewModels;

namespace xamarinsimplenavigation.Views
{
    public partial class StartPageView : ContentPage
    {
        public StartPageView()
        {
            InitializeComponent();
			this.BindingContext = new StartPageViewModel();
        }
    }
}
