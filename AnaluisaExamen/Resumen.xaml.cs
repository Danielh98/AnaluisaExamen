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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string montoInicial, string cuotaUno, string cuotaDos, string cuotaTres, string total)
        {
            InitializeComponent();

            txtUsuarioConectado.Text = usuario;
            txtNombreResumen.Text = nombre;
            txtCuotaInicialResumen.Text = montoInicial;
            txtCuotaUnoResumen.Text = cuotaUno;
            txtCuotaDosResumen.Text = cuotaDos;
            txtCuotaTresResumen.Text = cuotaTres;
            txtTotalResumen.Text = total;
        }
    }
}