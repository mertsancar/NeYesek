using Ne_Yesek_App.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ne_Yesek_App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParameterPage : ContentPage
    {
        private List<Meals> _rootobj;
 



        //ProcessingData test = new ProcessingData();
        //test.Data(_rootobj);



        public ParameterPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);


            var assembly = typeof(ParameterPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Ne_Yesek_App.Database.meals.json");

            Task.Run(() =>

            {
                using (var reader = new System.IO.StreamReader(stream, Encoding.GetEncoding("iso-8859-9")))
                {
                    var json = reader.ReadToEnd();

                    List<Meals> mylist = JsonConvert.DeserializeObject<List<Meals>>(json);
                    _rootobj = new List<Meals>(mylist);
                }
            }

             );

        }


        async void Handle_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void Sliderhungry_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            hungry_level.Text = ((int)hungry_slider.Value).ToString();
        }


        async void Get_Random_Food(object sender, EventArgs e)
        {             
            var temp = new List<Meals>();

            temp.AddRange(_rootobj);

            int x = 0;

            while (x != 40)
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Hungry != (int)hungry_slider.Value)
                    {
                        temp.Remove(temp[i]);
                    }
                    else if (temp[i].Time != time_after.IsChecked)
                    {
                        temp.Remove(temp[i]);
                    }
                    // buralar ilerde sıkıntı olacak

                }
                x++;    
            }
            


            Random rnd = new Random();
            int random = rnd.Next(temp.Count);


           await Navigation.PushAsync(new LoadingPage(temp[random].Meal));




        }

    }
}