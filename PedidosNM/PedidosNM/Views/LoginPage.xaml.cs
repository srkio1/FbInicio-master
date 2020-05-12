using PedidosNM.ViewModels;
using PedidosNM.ViewModels.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PedidosNM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			//BindingContext = new SocialLoginPageViewModel();
			NavigationPage.SetHasNavigationBar(this, false);
			BindingContext = new LoginPageViewModel();
		}
	}
}