using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ne_Yesek_App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YourMealPage : ContentPage
    {
        private string _your_meal;

        
        public YourMealPage(string _your_meal)
        {
            InitializeComponent();

            
        //borek.Source = "//cdn.yemeksepeti.com/productimages/TR_ISTANBUL/mcdonalds/big-mag-menu_big.jpg";

        //cdn.yemeksepeti.com/App_Themes/cuisines/discover/burger.png

        //cdn.yemeksepeti.com/App_Themes/SiteHeaders/Hamburger.jpg

         NavigationPage.SetHasNavigationBar(this, false);

            your_meal.Text = _your_meal;
            this._your_meal = _your_meal;


        }

        async void Handle_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Get_Order(object sender, EventArgs e)
        {
            string yemeksepeti = $"https://www.yemeksepeti.com/istanbul//arama#ors:true|tp:8|sd:false|st:{_your_meal}";

            await Browser.OpenAsync(yemeksepeti, BrowserLaunchMode.SystemPreferred);
        }

        private async void Get_Recipe(object sender, EventArgs e)
        {
            string yemeksepeti = $"https://www.nefisyemektarifleri.com/ara/?s={_your_meal}";

            await Browser.OpenAsync(yemeksepeti, BrowserLaunchMode.SystemPreferred);
        }
    }
}