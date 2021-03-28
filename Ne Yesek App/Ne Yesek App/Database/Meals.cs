using System;
using System.Collections.Generic;
using System.Text;

namespace Ne_Yesek_App.Database
{
    public class Meals
    {
        public string Meal { get; set; }
        public int Hungry { get; set; }
        public bool Time { get; set; }


    }

    public class Root
    {
        public List<Meals> Meals { get; set; }
    }
}
