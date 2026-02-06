using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZonderNaam
{
    public class Naam
    {
        private String _voornaam;
        private String _familienaam;

        public Naam(String voornaam, String familienaam)
        {
            _voornaam = voornaam;
            _familienaam = familienaam;
        }

        public String Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public String Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }

        public String Volledigenaam(bool formeel)
        {
            String naam;

            if (formeel == true)
            {
                naam = _familienaam + " " + _voornaam;
            }
            else
            {
                naam = _voornaam + " " + _familienaam;
             }

            return naam;
        }

        public String Initialen()
        {
            String initialen = "";
            initialen += Voornaam.Substring(0,1) + ".";
            initialen += Familienaam.Substring(0, 1) + ".";
            return initialen;
        }

        public String AlfaVoornaam()
        {
            String alfa = "";
            alfa += Voornaam.ToLower().Replace("é", "e").Replace("è", "e").Replace("ç", "c");
            return alfa;
        }

        public String AlfaFamilienaam()
        {
            String alfa = "";
            alfa += Familienaam.ToLower().Replace("é", "e").Replace("è", "e").Replace("ç", "c").Replace(" ", "");
            return alfa;
        }

    }
}
