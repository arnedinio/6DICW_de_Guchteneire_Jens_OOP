using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CocktailBar
{
    public class Cocktail
    {
        //Velden
        private String _naam; //Naam van de cocktail
        private decimal _kostprijs; //Prijs van de cocktail
        private List<Ingredient> _ingredienten; //Lijst van ingrediënten in de cocktail

        //Constructors
        public Cocktail(String naam, decimal kostprijs)
        {
            this._naam = naam;
            this._kostprijs = kostprijs;
        }

        //Properties
        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public decimal Kostprijs
        {
            get { return _kostprijs; }
            set { _kostprijs = value; }
        }

        public List<Ingredient> Ingredienten
        {
            get { return _ingredienten; }
        }

        //Methodes
        public void VoegIngredientToe(Ingredient ingredient)
        {
            if (ingredient != null && !Ingredienten.Contains(ingredient) && ingredient.Hoeveelheid > 0)
            {
                this._ingredienten.Add(ingredient);
            }
        }

        public int HoeveelIngredienten()
        {
            return this._ingredienten.Count;
        }

        public int InhoudCocktail()
        {
            int totaal = 0;
            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient != null)
                {
                    totaal += ingredient.Hoeveelheid;
                }
            }

            return totaal;
        }

        public int HoeveelAlcoholischeIngrediënten()
        {
            int totaal = 0;
            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient != null && ingredient.isAlcoholisch())
                {
                    totaal++;
                }
            }

            return totaal;
        }

        public bool IsAlcoholisch()
        {
            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient != null && ingredient.isAlcoholisch())
                {
                    return true;
                }
            }

            return false;
        }

        public String AlleIngredienten()
        {
            String uitkomst = "";
            if (this._ingredienten.Count > 0)
            {
                foreach (Ingredient ingredient in _ingredienten)
                {
                    uitkomst += (ingredient.Hoeveelheid + " ml " + ingredient.Naam + "; ");
                }
            }
            else
            {
                uitkomst += "Geen ingrediënten toegevoegd.";
            }

            return uitkomst;
        }

        public Ingredient GeefIngredient(int index)
        {
            if (index >= 0 && index < _ingredienten.Count)
            {
                return _ingredienten[index];
            }

            return null;
        }

        public String GeefNaamIngredient(int index)
        {
            return GeefIngredient(index).Naam;
        }

        public void VerwijderIngredient(int index)
        {
            if (index >= 0 && index < _ingredienten.Count)
            {
                _ingredienten.RemoveAt(index);
            }
        }

        public void MaakAlcoholVrij(decimal nieuwPrijs)
        {
            this._kostprijs = nieuwPrijs;
            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient.isAlcoholisch())
                {
                    this._ingredienten.Remove(ingredient);
                }
            }
        }

        public double AlcoholPercentage()
        {
            double totaal = 0;
            double alcoholisch = 0;
            foreach (Ingredient ingredient in _ingredienten)
            {
                totaal += ingredient.Hoeveelheid;
                if (ingredient.isAlcoholisch())
                {
                    alcoholisch += ingredient.Hoeveelheid * ingredient.Alcoholpercentage;
                }
            }

            if (totaal > 0)
            {
                return alcoholisch / totaal * 100;
            }
            else
            {
                return 0;
            }
        }
        public List<Ingredient> GeefAlcoholischeIngredienten()
        {
            List<Ingredient> alcoholischeIngredienten = new List<Ingredient>();
            foreach (Ingredient ingredient in this._ingredienten)
            {
                if (ingredient.isAlcoholisch())
                {
                    alcoholischeIngredienten.Add(ingredient);
                }
            }
            return alcoholischeIngredienten;
        }
        public List<Ingredient> GeefNietAlcoholischeIngredienten()
        {
            List<Ingredient> nietAlcoholischeIngredienten = new List<Ingredient>();
            foreach (Ingredient ingredient in this._ingredienten)
            {
                if (!ingredient.isAlcoholisch())
                {
                    nietAlcoholischeIngredienten.Add(ingredient);
                }
            }
            return nietAlcoholischeIngredienten;
        }
    }
}
