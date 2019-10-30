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
    public partial class DetailMedicametos : ContentPage
    {
        public DetailMedicametos(Product product)
        {
            InitializeComponent();
            LoadData(product);
            
        }

        private void LoadData(Product contact)
        {
            Datos.BindingContext = contact;
        }
        async private void Cargar_Click(object sender, EventArgs e)
        {
            await DisplayAlert("COMPLETADO", "La reserva se hagenerado correctamente", "Aceptar");
        }


    }
}