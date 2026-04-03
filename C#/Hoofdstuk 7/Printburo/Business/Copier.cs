using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Copier
    {
        private int _teller;
        private List<Printopdracht> _wachtrij;

        public Copier()
        {
            _teller = 0;
            _wachtrij = new List<Printopdracht>();
        }
        
        public int Teller
        {
            get { return _teller; }
        }

        public List<Printopdracht> Wachtrij
        {
            get { return _wachtrij; }
        }

        // nog te programmeren ...
        // deze methode laat een nieuwe printopdracht op de wachtrij zetten
        // ----------------------------------------------------------------
        public Printopdracht VoegPrintopdrachtToe(int aantalPaginas, int aantalExemplaren)
        {
            Printopdracht opdracht = new Printopdracht(aantalPaginas, aantalExemplaren);
            _wachtrij.Add(opdracht);
            return opdracht;
        }

        // nog te programmeren ...
        // deze methode laat de eerste printopdracht in de wachtrij verwerken
        // ------------------------------------------------------------------
        public void Print()
        {
            if (_wachtrij != null && _wachtrij.Count() > 0)
            {
                _teller += _wachtrij[0].AantalExemplaren * _wachtrij[0].PaginasOrigineel;
                _wachtrij.RemoveAt(0);
            }
        }

            public void PrintMetVoorrang(Printopdracht _opdracht)
            {
                if (_opdracht != null)
                {
                    _teller += _opdracht.AantalExemplaren * _opdracht.PaginasOrigineel;
                }

                _wachtrij.Remove(_opdracht);
            }
    }
}
