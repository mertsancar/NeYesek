using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ne_Yesek_App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingPage : ContentPage
    {
        public LoadingPage(string meal)
        {
            InitializeComponent();


            //Thread.Sleep(5000);

            //Navigation.PushAsync(new YourMealPage(meal));
        }
    }
}