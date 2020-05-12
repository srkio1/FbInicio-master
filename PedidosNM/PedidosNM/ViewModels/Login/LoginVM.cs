using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PedidosNM.ViewModels.Login
{
	public class LoginVM : INotifyPropertyChanged
	{
		public ICommand OnLoginCommand { get; set; }
		public LoginVM()
		{
			OnLoginCommand = new Command(async () => await LoginUserAsync());
		}
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		private string usuario;
		public string Usuario
		{
			get => usuario;
			set
			{
				if (usuario != value) { usuario = value; }
				OnPropertyChanged();
			}
		}



		private string password;
		public string Password
		{
			get => password;
			set
			{
				if (password != value) { password = value; }
				OnPropertyChanged();
			}
		}
		async Task LoginUserAsync()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
