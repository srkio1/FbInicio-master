using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosNM.Models
{
	public class Producto
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public int Id_tipo_producto { get; set; }
		public string Precio { get; set; }
		public string Medida { get; set; }
		public string Imagen { get; set; }
	}
}
