using System;
using System.Collections.Generic;
using System.Text;

namespace drielagenmodel_kindvoorspeller_Jens_deGuchteneire
{
    internal class KindLengteVoorspeller
    {
        //Velden
        private double _lengteMan;        //Lengte van de Vader
        private double _lengteVrouw;      //Lengte van de Moeder
        private int _aantalVoorspellingen;//Aantal keer dat de klasse heeft voorspeld

        
        //Constructor maakt object van klasse KindLengteVoorspeller met basis man 180 cm en vrouw 165 cm
        public KindLengteVoorspeller()
        {
            _lengteMan = 180;
            _lengteVrouw = 165;
            _aantalVoorspellingen = 0;
        }

        
        //Properties
        public double LengteMan
        {
            get { return _lengteMan; }
            set { _lengteMan = value; }
        }

        public double LengteVrouw
        {
            get { return _lengteVrouw; }
            set { _lengteVrouw = value; }
        }
        public int AantalVoorspellingen
        {
            get { return _aantalVoorspellingen ; }
            set { _aantalVoorspellingen = value; }
        }


        public double GemiddeldeOuders()
        {
            return (_lengteVrouw + _lengteMan) / 2;
        }

        public double BerekenDochter()
        {
            return (GemiddeldeOuders() - 6.5);
        }

        public double BerekenZoon()
        {
            return GemiddeldeOuders() + 6.5;
        }


    }
}
