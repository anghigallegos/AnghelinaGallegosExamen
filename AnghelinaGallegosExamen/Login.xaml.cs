using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AnghelinaGallegosExamen
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void btnIngresar_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!txtUsuario.Text.Equals("estudiante2020") || !txtClave.Text.Equals("uisrael2020"))
            {
                DisplayAlert("Alerta!", "Credenciales incorrectas", "Cerrar");
            }
            else
            {
                        await Navigation.PushAsync(new Registro(txtUsuario.Text));

                    
            }

        }

    }
}
