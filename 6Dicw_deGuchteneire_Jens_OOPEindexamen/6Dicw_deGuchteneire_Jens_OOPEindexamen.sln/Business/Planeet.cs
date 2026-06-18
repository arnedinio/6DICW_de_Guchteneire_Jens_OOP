using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Business
{
    public class Planeet
    {
        //Velden
        private int _id;
        private String _naam;
        private String _zonnestelsel;
        private bool _woonbaar;
        private long _literWater;

        //Ik weet dat we auto properties niet geleerd hebben, maar ik heb dit gisteren ontdekt en wil het gebruikenm

        //Constructor
        public Planeet(int id, String naam, String zonnestelsel, bool woonbaar, long literWater)
        {
            Id = id;
            Naam = naam;
            Zonnestelsel = zonnestelsel;
            Woonbaar = woonbaar;
            LiterWater = literWater;
        }

        //(auto-)Properties
        public int Id { get; set; }
        public String Naam { get; set; }
        public String Zonnestelsel { get; set; }
        public bool Woonbaar { get; set; }
        public long LiterWater { get; set; }
}
}
