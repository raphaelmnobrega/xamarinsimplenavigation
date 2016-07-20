using xamarinsimplenavigation.ViewModels;
using Xamarin.Forms;

namespace xamarinsimplenavigation.Views
{
    public partial class MainPageView : TabbedPage
    {
        public MainPageView()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
