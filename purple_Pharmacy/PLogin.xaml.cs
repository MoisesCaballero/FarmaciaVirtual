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
    public partial class LoginPage : ContentPage
    {


        public LoginPage()
        {
            InitializeComponent();
            btLogin.Clicked += BtLogin_Clicked;
        }


        private async void BtLogin_Clicked(object sender, EventArgs e)
        {


            await ((NavigationPage)this.Parent).PushAsync(new DomicilesPage());


        }




    }
}