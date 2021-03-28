using Ne_Yesek_App.Database;
using Ne_Yesek_App.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ne_Yesek_App
{
    public partial class MainPage : ContentPage
    {

       
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            

            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream("Ne_Yesek_App.Music.owyeah.mp3");


            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(audioStream);
            player.Play();


        }

        async void Handle_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ParameterPage());
        }

        
    }
}
