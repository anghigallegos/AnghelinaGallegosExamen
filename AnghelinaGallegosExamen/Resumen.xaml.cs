using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AnghelinaGallegosExamen
{
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombreUsuario, string pagoTotal)
        {
            InitializeComponent();
            txtNombreUsuario.Text = nombreUsuario;
            txtUsuario.Text = usuario;
            txtPagoFinal.Text = pagoTotal;
        }
    }
}
