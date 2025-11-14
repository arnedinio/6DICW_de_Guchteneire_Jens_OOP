using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reisbureau
{
    public class Groepsreis
    {
        //Velden
        private String _bestemming;
        private int _maxDeelnemers;
        private int _inschrijvingen;
        private double _prijsPerPersoon;
        private bool _kinderenToegelaten;
        private char _klasseVerblijf;


        //Constructors
        public Groepsreis(String _bestemming, int _maxDeelnemers, double _prijsPerPersoon)
        /**
         * Constructor voor de Groepsreis klasse. Enkel de bestemming, het maximum aantal deelnemers en de prijs per persoon worden meegegeven als parameters.
         */
        {
            this._bestemming = _bestemming;
            this._maxDeelnemers = _maxDeelnemers;
            this._prijsPerPersoon = _prijsPerPersoon;
            this._kinderenToegelaten = true;
            this._klasseVerblijf = 'B';
            this._inschrijvingen = 1;
        }


        //Accessors
        public String GetBestemming()
        {
            return _bestemming;
        }
        public int GetMaxDeelnemers()
        {
            return _maxDeelnemers;
        }
        public double GetPrijsPerPersoon()
        {
            return _prijsPerPersoon;
        }
        public bool GetKinderenToegelaten()
        {
            return _kinderenToegelaten;
        }
        public char GetKlasseVerblijf()
        {
            return _klasseVerblijf;
        }
        public int GetInschrijvingen()
        {
            return _inschrijvingen;
        }


        //Mutators
        public void SetPrijsPerPersoon(double _prijsPerPersoon)
        {
            this._prijsPerPersoon = _prijsPerPersoon;
        }
        public void SetKinderenToegelaten(bool _kinderenToegelaten)
        {
            this._kinderenToegelaten = _kinderenToegelaten;
        }
        public void SetKlasseVerblijf(char _klasseVerblijf)
        {
            this._klasseVerblijf = _klasseVerblijf;
        }


        //Methoden
        public void VolwasseneInschrijving()
            /**
             * Schrijft een volwassene in voor de groepsreis, enkel en alleen als het maximum aantal deelnemers niet overschreden wordt.
             */
        {
            if (_inschrijvingen < _maxDeelnemers)
            {
                _inschrijvingen++;
            }
            else
            {
                Console.Out.WriteLine("Te veel deelnemers");
            }
        }
        
        public void KindInschrijving(int AantalKinderen)
        /**
        * Schrijft een bepaald aantal kinderen in voor de groepsreis, enkel en alleen als kinderen toegelaten zijn en het maximum aantal deelnemers niet overschreden wordt.
        */
        {
            if (_kinderenToegelaten)
            {
                if (_inschrijvingen + AantalKinderen <= _maxDeelnemers)
                {
                    _inschrijvingen += AantalKinderen;
                }
                else
                {
                    Console.Out.WriteLine("Te veel deelnemers");
                }
            }
            else
            {
                Console.Out.WriteLine("Kinderen niet toegelaten");
            }
        }
    }
}
