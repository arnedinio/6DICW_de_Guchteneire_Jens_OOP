using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailBar
{
    public class Ingredient
    {
        //Velden
        private String _naam; //Naam van het ingrediënt
        private int _hoeveelheid; //Hoeveelheid van het ingrediënt in ml
        private double _alcoholpercentage; //Alcoholpercentage van het ingrediënt

        //Constructors
        public Ingredient(String naam, int hoeveelheid, double alcoholpercentage)
        {
            this._naam = naam;
            this._hoeveelheid = hoeveelheid;
            this._alcoholpercentage = alcoholpercentage;
        }

        //Properties
        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int Hoeveelheid
        {
            get { return _hoeveelheid; }
            set { _hoeveelheid = value; }
        }
        public double Alcoholpercentage
        {
            get { return _alcoholpercentage; }
            set { _alcoholpercentage = value; }
        }

        //Methodes
        public bool isAlcoholisch()
        {
            if (this._alcoholpercentage > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
