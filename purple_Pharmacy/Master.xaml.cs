
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using purple_Pharmacy.Views;
using product.Domain;

namespace purple_Pharmacy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DomicilesPage : MasterDetailPage
    {
        public DomicilesPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            
            List<Menu> menu = new List <Menu>
            {
                new Menu { MenuTitle = "Medicinas" },
                new Menu {MenuTitle = "Ventas" },
                new Menu {MenuTitle = "Cerrar" },
            };
            ListMenu.ItemsSource = menu;
            Detail = new NavigationPage(new DomicilioPage());
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if(menu!= null)
            {
                if(menu.MenuTitle.Equals("Medicinas"))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new Medicamentos()) ;

                }
                else if (menu.MenuTitle.Equals("Ventas"))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new OrdersPage());
                }
                else if (menu.MenuTitle.Equals("Cerrar"))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new LoginPage());
                }


            }
        }
    }
   
    public class Menu
    {

        public string MenuTitle
        {
            get;
            set;
        }
        public object MenuDetail
        {
            get;
            set;
        }
        
    }
}