using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WilsonQuishpe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string estudiante)
        {
            InitializeComponent();
            lblEstudiante.Text = "Estudiante Conectado: " + estudiante;
        }

        private void btnCalcularPM_Clicked(object sender, EventArgs e)
        {

            int valor = 3000;

            double pMensual = (valor - double.Parse(txtCInicial.Text)) / 5;

            double pagoMensualTotal = (pMensual * 0.05) + pMensual;

            if (double.Parse(txtCInicial.Text) < 3000)
            {

                txtPago.Text = pagoMensualTotal.ToString();
            }
            else
            {
                DisplayAlert("Atención", "El valor no debe sobrepasar 3000", "OK");
            }
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
          
            if (double.Parse(txtCInicial.Text) < 3000)
            {
                await DisplayAlert("Atención", "Registro guardado con éxtio", "OK");
                double total = double.Parse(txtCInicial.Text) + (double.Parse(txtPago.Text) * 5);

                await Navigation.PushAsync(new Resumen(lblEstudiante.Text, txtNombre.Text, total));
            }
            else
            {
               await DisplayAlert("Atención", "El valor no debe sobrepasar 3000", "OK");
            }

        }
    }
}