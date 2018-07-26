using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyApp
{
    public partial class Views : ContentPage
    {
		public Views()
		{
			InitializeComponent();
			dtpFecha.MinimumDate = new DateTime(2000, 1, 1);
			dtpFecha.DateSelected += DtpFecha_DateSelected;
		}

		void DtpFecha_DateSelected(object sender, DateChangedEventArgs e)
		{
			DisplayAlert("Fecha", e.NewDate.ToString(), "Aceptar");
		}

		private void btnEnviarClicked(object sender, EventArgs args){
			DisplayAlert("Ingreso", "Bienvenido a la aplicacion", "Aceptar");

		}
    }
}
