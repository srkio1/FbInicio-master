using Newtonsoft.Json;
using PedidosNM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Text;

namespace PedidosNM.ViewModels.Productos
{
	public class ListaProductosInicioVM : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		private ObservableCollection<Producto> _listaDeProducto;
		public ObservableCollection<Producto> ListaDeProducto
		{
			get { return _listaDeProducto; }
			set
			{
				if (_listaDeProducto != value)
				{
					_listaDeProducto = value;
					OnPropertyChanged("ListaDeProducto");
				}
			}
		}
		public ListaProductosInicioVM()
		{
			_listaDeProducto = new ObservableCollection<Producto>();
			GetProducto();
		}
		public async void GetProducto()
		{
			HttpClient client = new HttpClient();
			var response = await client.GetStringAsync("http://dmrbolivia.online/api_pedidos/productos/listaProducto.php");
			var producto_lista = JsonConvert.DeserializeObject<List<Producto>>(response);
			foreach (var item in producto_lista)
			{
				_listaDeProducto.Add(new Producto
				{
					Id = item.Id,
					Nombre = item.Nombre,
					Id_tipo_producto = item.Id_tipo_producto,
					Precio = "Bs. " + item.Precio,
					Medida = item.Medida,
					Imagen = "http://dmrbolivia.online" + item.Imagen
				});
			}
		}
	}
}
