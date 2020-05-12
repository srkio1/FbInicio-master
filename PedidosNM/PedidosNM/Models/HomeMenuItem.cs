using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosNM.Models
{
	public enum MenuItemType
	{
		Inicio,
		Direccion,
		Pedidos,
		Cuenta,
		Info,
		Contactanos
	}
	public class HomeMenuItem
	{
		public MenuItemType Id { get; set; }

		public string Title { get; set; }
	}
}
