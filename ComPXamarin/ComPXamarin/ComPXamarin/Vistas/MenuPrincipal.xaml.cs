using ComPXamarin.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComPXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public IList<Mcomidas> Comidas { get; private set; }
        public MenuPrincipal()
        {
            InitializeComponent();

            Comidas = new List<Mcomidas>();

            Comidas.Add(new Mcomidas { 
                Nombre = "Ceviche",
                Imagen = "Flecha.png"
            });

            Comidas.Add(new Mcomidas {
                Nombre = "Alertas",
                Imagen = "Alertas.png"
            });

            Comidas.Add(new Mcomidas
            {
                Nombre = "Tarjetas",
                Imagen = "Tarjetas.png"
            });

            BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Mcomidas seleccion = e.Item as Mcomidas;

            if(seleccion.Nombre == "Tarjetas")
            {
                Navigation.PushAsync(new Tarjetas());
            }

            if (seleccion.Nombre == "Alertas")
            {
                Navigation.PushAsync(new Alertas());
            }
        }
    }
}