using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            else if (!UserName.Text.ToCharArray().All(Char.IsLetter))
            {
                await this.DisplayAlert("Advertencia", "Tu informacion contiene caracteres especiales.", "Aceptar");
            }else{
                string caractEspecial = @"^[^ ] [a-zA-Z ]+[^ ]$";
                bool resultado = Regex.IsMatch(UserName.Text, caractEspecial, RegexOptions.IgnoreCase);
                if(!resultado){
                    await this.DisplayAlert("Advertencia", "No se aceptan caracteres especiales, intente de nuevo", "Aceptar");
                    return false;
                }
            }

            if (String.IsNullOrWhiteSpace(UserLastName.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo del nombre es obligatorio.", "Aceptar");
                return false;
            }
            else if (!UserLastName.Text.ToCharArray().All(Char.IsLetter))
            {
                await this.DisplayAlert("Advertencia", "Tu informacion contiene caracteres especiales.", "Aceptar");
            }
            else
            {
                string caractEspecial = @"^[^ ] [a-zA-Z ]+[^ ]$";
                bool resultado = Regex.IsMatch(UserLastName.Text, caractEspecial, RegexOptions.IgnoreCase);
                if (!resultado)
                {
                    await this.DisplayAlert("Advertencia", "No se aceptan caracteres especiales, intente de nuevo", "Aceptar");
                    return false;
                }
            }

            if (String.IsNullOrWhiteSpace(UserEmail.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo del correo electrónico es obligatorio.", "Aceptar");
                return false;
            }
            else if (!UserLastName.Text.ToCharArray().All(Char.IsLetter))
            {
                await this.DisplayAlert("Advertencia", "Tu Correo contiene caracteres especiales.", "Aceptar");
            }
            else
            {
                bool isEmail = Regex.IsMatch(UserEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{}])");
            }
        }
    }
}
