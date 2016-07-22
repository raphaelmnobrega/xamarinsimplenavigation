using System;
using System.Collections.Generic;

using Xamarin.Forms;
using xamarinsimplenavigation.ViewModels;

namespace xamarinsimplenavigation
{
	public partial class LoginView : ContentPage
	{
		public LoginView()
		{
			InitializeComponent();
			this.BindingContext = new LoginViewModel();
		}
	}
}

