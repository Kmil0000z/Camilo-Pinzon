using System;

using Xamarin.Forms;

namespace MyApp
{
    public class Views : ContentPage
    {
        public Views()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

