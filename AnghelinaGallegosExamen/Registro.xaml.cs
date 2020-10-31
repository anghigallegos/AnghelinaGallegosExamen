using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AnghelinaGallegosExamen
{
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {

            InitializeComponent();
            txtUsuario.Text = usuario;
        }

        async void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {
            double monto = Convert.ToDouble(txtMonto.Text);
            if (monto > 1800)
            {
                DisplayAlert("Alerta", "No puede ser mayor a $1800", "Aceptar");
            }
            else
            {
                if (monto < 0)
                {
                    DisplayAlert("Alerta", "No puede ser menor a $0", "Aceptar");
                }
                else
                {
                    if (monto <= 1800)
                    {
                        double montoP = Convert.ToDouble(txtMonto.Text);
                        double restanteP = 1800 - montoP;
                        restanteP = restanteP + (restanteP * 0.05);
                        restanteP = restanteP / 3;
                        txtPago.Text = restanteP.ToString();


                    }
                }
            }
        }
        async void btnResumen_Clicked(System.Object sender, System.EventArgs e)
        {

            double pagoTotal = Convert.ToDouble(txtMonto.Text) + Convert.ToDouble(txtPago.Text) * 3;
            DisplayAlert("Alerta", "Guardado correctamente", "Aceptar");
            await Navigation.PushAsync(new Resumen(txtUsuario.Text, txtNombre.Text, pagoTotal.ToString()));
        }

    }
}
