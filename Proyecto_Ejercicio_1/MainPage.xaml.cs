using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto_Ejercicio_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

private async void btn_guardar(object sender, EventArgs e)
        {

            String nombre = nombres.Text;
            String apellido = apellidos.Text;
            String edades = edad.Text;
            String correo = correos.Text;

            await Navigation.PushAsync(new Pagina_2(nombre, apellido, edades, correo));



        }
    }
}
