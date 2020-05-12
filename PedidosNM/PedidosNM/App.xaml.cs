using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PedidosNM.Views;
using PedidosNM.Helpers;
using PedidosNM.ViewModels;

namespace PedidosNM
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();
			if(UserSettings.UserName == string.Empty)
			{
				MainPage = new NavigationPage(new LoginPage());
			}
			else
			{
				MainPage = new NavigationPage(new MainPage());
			}
			//MainPage = new NavigationPage(new DetailsPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
