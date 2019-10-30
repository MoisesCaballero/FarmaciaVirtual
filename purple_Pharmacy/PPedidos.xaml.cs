using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product.Domain;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace purple_Pharmacy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersPage : ContentPage
    {
        public OrdersPage()
        {

            InitializeComponent();
          


        }
        
         private async void OnItemSelected(object sender, SelectableItemsView e)
        {
            if (ListDatos.SelectedItem != null)
            {
                var detailPage = new Medicamentos();
                detailPage.BindingContext = e.SelectedItem as Product;
                ListDatos.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }




    }
}