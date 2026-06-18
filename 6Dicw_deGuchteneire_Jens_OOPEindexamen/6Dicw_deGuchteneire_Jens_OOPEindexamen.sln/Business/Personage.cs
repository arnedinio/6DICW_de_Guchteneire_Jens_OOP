using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Personage
    {
        //Velden
        private int _id;
        private String _naam;
        private String _rol;
        private int _leeftijd;
        private bool _isCylon;

        //Ik weet dat we auto properties niet geleerd hebben, maar ik heb dit gisteren ontdekt en wil het gebruikenm

        //Constructor
        public Personage(int id, string naam, string rol, int leeftijd, bool isCylon)
        {
            Id = id;
            Naam = naam;
            Rol = rol;
            Leeftijd = leeftijd;
            IsCylon = isCylon;
        }

        //(Auto-)Properties
        public int Id { get; set; }
        public String Naam {get; set; }
        public String Rol { get; set; }
        public int Leeftijd { get; set; }
        public bool IsCylon { get; set; }
}
}
