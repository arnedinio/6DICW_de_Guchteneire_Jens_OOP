using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndBusiness
{
    public class DnD
    {
        //Velden
        private List<Karakter> _lsKarakters;

        //Constructor
        public DnD()
        {
            _lsKarakters = new List<Karakter>();
        }

        //Properties
        public List<Karakter> Karakters
        {
            get { return _lsKarakters; }
        }

        //Methodes

        //Met parameter naam, controleert of karakter aanwezig is
        public bool Aanwezig(String naam)
        {
            foreach (Karakter k in this._lsKarakters)
            {
                if (k.Naam.Equals(naam))
                {
                    return true;
                }
            }
            return false;
        }

        //Met parameter naam, zoekt karakter met die naam. Returnt null als naam niet voorkomt
        public Karakter GeefKarakter(String naam)
        {
            if (Aanwezig (naam))
            {
                foreach (Karakter k in this._lsKarakters)
                {
                    if (k.Naam.Equals(naam))
                    {
                        return k;
                    }
                }
            }
            return null;
        }

        //Voegt een karakter toe aan de lijst van karakters enkel en alleen als de naam nog niet aanwezig is
        public void VoegToe(String naam, int sterkte)
        {
            if (Aanwezig(naam))
            {
                DetailForm form = new DetailForm(null);
                form.Show();
                return;
            }
            this._lsKarakters.Add(new Karakter(naam, sterkte));
        }
    }
}
