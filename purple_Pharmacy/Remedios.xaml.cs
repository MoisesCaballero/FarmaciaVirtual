using product.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace purple_Pharmacy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Medicamentos : ContentPage
    {
        public Medicamentos()
        {

            InitializeComponent();
            LoadContacts();
        }


        private void LoadContacts()
        {
            var contactclist = new List<Product>
            {

                new Product { FullName = "Remedio_1", NombreGenerico ="xxxxxxxxx", Precio ="8.235 $", Codigo ="xxxxxx",  ImageUrl ="Remedio2.png"},
                new Product { FullName = "Remedio_2", NombreGenerico ="xxxxxxxxx", Precio ="1.365 $", Codigo ="xxxxxxx", ImageUrl ="Remedio1.png"},
                new Product { FullName = "Remedio_3", NombreGenerico ="xxxxxxxxx ", Precio ="7.123 $", Codigo ="xxxxx", ImageUrl ="Remedio3.png"},
                new Product { FullName = "Remedio_4", NombreGenerico ="xxxxxxxxx", Precio ="65.125 $", Codigo ="xxxxxx", ImageUrl ="Remedio1.png"},

            };

            lsContact.ItemsSource = contactclist;
        }

               

        private void Contact_selected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactselected = (Product)e.SelectedItem;
            Navigation.PushAsync(new DetailMedicametos(contactselected));
        }
    }
}