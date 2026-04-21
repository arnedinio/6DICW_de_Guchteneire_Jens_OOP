using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndBusiness
{
    public class Karakter
    {
        //Velden
        private String _naam;
        private int _sterkte;

        //Constructor
        public Karakter(String naam, int sterkte)
        {
            this._naam = naam;
            this._sterkte = sterkte;
        }

        //Properties
        public String Naam
        {
            get { return this._naam; }
            set { this._naam = value; }
        }

        public int Sterkte
        {
            get { return this._sterkte; }
            set { this._sterkte = value; }
        }

        //Geeft returnwaarde als "Naam: x Sterkte: y"
        public override String ToString()
        {
            return _naam;
        }
    }
}
