using PedidosNM.Helpers;
using PedidosNM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PedidosNM.ViewModels
{
	public class DetailsPageViewModel : BasePageViewModel
    {
        public ICommand LogoutCommand
        {
            get;
            private set;
        }
        public DetailsPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
            LogoutCommand = new Command(() => ResetUserInfo());
        }
        void ResetUserInfo()
        {
            _navigation.PushAsync(new LoginPage());
            UserSettings.ClearAllData();
        }
    }
}
