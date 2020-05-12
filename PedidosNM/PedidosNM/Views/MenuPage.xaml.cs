using PedidosNM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PedidosNM.Views
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MenuPage : ContentPage
	{
		MainPage RootPage { get => Application.Current.MainPage as MainPage; }
		List<HomeMenuItem> menuItems;
		public MenuPage()
		{
			InitializeComponent();

			menuItems = new List<HomeMenuItem>
			{
				new HomeMenuItem {Id = MenuItemType.Inicio, Title="Inicio" },
				new HomeMenuItem {Id = MenuItemType.Direccion, Title="Mis direcciones" },
				new HomeMenuItem {Id = MenuItemType.Pedidos, Title="Mis pedidos" },
				new HomeMenuItem {Id = MenuItemType.Cuenta, Title="Mi cuenta" },
				new HomeMenuItem {Id = MenuItemType.Info, Title="Informacion" },
				new HomeMenuItem {Id = MenuItemType.Contactanos, Title="Contactanos" }
			};

			ListViewMenu.ItemsSource = menuItems;

			ListViewMenu.SelectedItem = menuItems[0];
			ListViewMenu.ItemSelected += async (sender, e) =>
			{
				if (e.SelectedItem == null)
					return;

				var id = (int)((HomeMenuItem)e.SelectedItem).Id;
				await RootPage.NavigateFromMenu(id);
			};
		}
	}
}