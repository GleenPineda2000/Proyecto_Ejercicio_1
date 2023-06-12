using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Ejercicio_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina_2 : ContentPage
    {
        public Pagina_2(String nombre, String apellido,String edades, String correo )
        {
            InitializeComponent();
            datos.Text = "Datos" + nombre + " " + apellido + " " + edades + " " + correo;

        }
    }
}