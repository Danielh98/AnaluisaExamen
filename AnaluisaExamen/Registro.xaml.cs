using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnaluisaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;

            

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int montoMaximo = 1800;
            double interes = 90;
            double montoInicial;
            double b;
            double division;
            double total;
            double a = Convert.ToDouble(txtMontoInicial.Text);



            try
            {
                

                if ( a > montoMaximo)

                {
                    DisplayAlert("Error", "Monto mayor a 1800", "OK");
                    txtMontoInicial.Text = " ";

                } else
                {
                    montoInicial = a;
                    b = montoMaximo - montoInicial;
                    division = (b / 3) + interes;
                    total = montoInicial + (division + division + division);


                    txtCuotaUno.Text = Convert.ToString(Math.Round(division,2));
                    txtCuotaDos.Text = Convert.ToString(Math.Round(division,2));
                    txtCuotaTres.Text = Convert.ToString(Math.Round(division,2));
                    txtTotal.Text = Convert.ToString(Math.Round(total,2));



                }
                
               


            }

            catch (Exception ex)
            {
                DisplayAlert("MENSAJE DE ALERTA", ex.Message, "ok");
            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string nombre = txtNombre.Text;
                string montoInicial = txtMontoInicial.Text;
                string cuotaUno = txtCuotaUno.Text;
                string cuotaDos = txtCuotaDos.Text;
                string cuotaTres = txtCuotaTres.Text;
                string total = txtTotal.Text;

                await DisplayAlert("Notificación", "Guardado con exito", "OK");
                await Navigation.PushAsync(new Resumen(usuario, nombre, montoInicial, cuotaUno, cuotaDos, cuotaTres, total));


            }

            catch (Exception ex)
            {
               await DisplayAlert("MENSAJE DE ALERTA", ex.Message, "ok");
            }


        }
    }
}