﻿using PedidosNM.ViewModels.Productos;
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
	public partial class Index : ContentPage
	{
		public Index()
		{
			InitializeComponent();
			BindingContext = new ListaProductosInicioVM();
		}
	}
}