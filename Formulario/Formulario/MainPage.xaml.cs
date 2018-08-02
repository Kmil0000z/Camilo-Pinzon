using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Formulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            async void Continue_Tapped(object sender, EventArgs e)
            {
                if (await validarFormulario())
                {
                    await DisplayAlert("Exito", "Todos tus datos cumplieron las validaciones", "Continuar");
                }
            }
        }
        private async Task<bool> validarFormulario()
        {
            if (String.IsNullOrWhiteSpace(UserName.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo del nombre es obligatorio.", "Aceptar");
                return false;
            }
             else if ()
            {

            }
        }
    }
}
