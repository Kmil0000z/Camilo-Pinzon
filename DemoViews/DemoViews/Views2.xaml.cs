using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoViews
{
    public partial class Views2 : ContentPage
    {
        public Views2()
        {
            InitializeComponent();
        }
        void pickMusic_SelectedIndexChange(object sender, System.EventArgs e){
            var elementoSeleccionado = pickMusic.SelectedItem.ToString();
            DisplayAlert("Genero Música", elementoSeleccionado, "Aceptar");
        }
        void btnSimular_Clicked(object sender, System.EventArgs e)
        {
            var progreso = progressNum.Progress;
            if (progreso == 1)
            {
                progressNum.ProgressTo(.1, 250, Easing.SpringOut);
            }
            else
            {
                progressNum.ProgressTo(1, 300, Easing.Linear);
                }
        }

        void Handle_SearchButtonPressed(object sender, System.EventArgs e)
        {
            DisplayAlert("Buscando", "Buscando Resultados", "Aceptar");
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            DisplayAlert("Cambiando", "Este texto está cambiando", "Aceptar");
        }
    }
}
