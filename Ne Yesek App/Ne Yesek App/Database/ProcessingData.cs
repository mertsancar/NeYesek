using Ne_Yesek_App.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ne_Yesek_App.Database
{
    public class ProcessingData
    {

        public async void Data(List<Meals> _rootobj)
        {
            
            var assembly = typeof(ParameterPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Ne_Yesek_App.Database.meals.json");

            await Task.Run(() =>

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

    }
}
