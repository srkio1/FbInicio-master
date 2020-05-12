using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PedidosNM.ViewModels
{
    public class UserLoginPageViewModel : BasePageViewModel
    {
        public ICommand LoginCommand
        {
            get;
            private set;
        }
        public UserLoginPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
            LoginCommand = new Command(() => UpdateUserInfo());
        }
        void UpdateUserInfo()
        {
            _navigation.PushAsync(new Views.MainPage());
        }
    }
}
