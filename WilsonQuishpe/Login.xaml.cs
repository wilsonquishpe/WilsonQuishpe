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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string estudiante = txtUsuario.Text;
            string contrasena = txtPass.Text;
            if (estudiante == "wilson2022" && contrasena == "uisrael2022")
            {
                await Navigation.PushAsync(new Registro(estudiante));
            }
            else
            {
                await DisplayAlert("Atención", "Datos Incorrectos", "OK");
            }
        }
    }
}