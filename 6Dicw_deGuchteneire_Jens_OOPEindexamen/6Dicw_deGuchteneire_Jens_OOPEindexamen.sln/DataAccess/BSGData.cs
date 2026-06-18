using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using MySql.Data.MySqlClient;
using Business;
using Mysqlx.Datatypes;

namespace DataAccess
{
    public class BSGData
    {
        //Velden
        private String _connString;
        private MySqlConnection _connection;
        
        //Constructor
        public BSGData()
        {
            _connString = "server=localhost;user id=root; Password=root; database=cylondetector";
            _connection = new MySqlConnection(_connString);
        }
        
        /*
         * Functiee die een lijst van alle personages in de lokale database teruggeeft
         */
        public List<Personage> GeefPersonages()
        {  
            List<Personage> personages = new List<Personage>();

            String sql = "select Id, Naam, Rol, Leeftijd, IsCylon from personages";

            MySqlCommand command = new MySqlCommand(sql, _connection);

            _connection.Open();

            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read() == true)
            {
                Personage personage = new Personage(
                    (int)dataReader["Id"],
                    (String)dataReader["Naam"],
                    (String)dataReader["Rol"],
                    (int)dataReader["Leeftijd"],
                    (bool)dataReader["IsCylon"]);

                personages.Add(personage);
            }

            _connection.Close();

            return personages;
        }

        /*
         * Functie die een lijst van alle planeten in de lokale database teruggeeft
         */
        public List<Planeet> GeefPlaneten()
        {
            List<Planeet> planeten = new List<Planeet>();

            String sql = "select Id, Naam, Zonnestelsel, WaterLiters, Bewoonbaar from planeten";

            MySqlCommand command = new MySqlCommand(sql, _connection);

            _connection.Open();

            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read() == true)
            {
                Planeet planeet = new Planeet(
                    (int)dataReader["Id"],
                    (String)dataReader["Naam"],
                    (String)dataReader["Zonnestelsel"],
                    (bool)dataReader["Bewoonbaar"],
                    (long)dataReader["WaterLiters"])
                    ;

                planeten.Add(planeet);
            }

            _connection.Close();

            return planeten;

        }

        /*
         * Functie die een lijst van alle schepen uit de lokale database teruggeeft
         */
        public List<Schip> GeefSchepen()
        {
            List<Schip> schepen = new List<Schip>();

            String sql = "select Id, Naam, Type, Bouwjaar, AantalBemanning, Status from vloot";

            MySqlCommand command = new MySqlCommand(sql, _connection);

            _connection.Open();

            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read() == true)
            {
                Schip schip = new Schip(
                    (int)dataReader["Id"],
                    (String)dataReader["Naam"],
                    (String)dataReader["Type"],
                    (int)dataReader["Bouwjaar"],
                    (int)dataReader["AantalBemanning"],
                    (String)dataReader["Status"]);

                schepen.Add(schip);
            }

            _connection.Close();

            return schepen;
        }

        /*
         * Verwijdert een gegeven personage uit de databank.
         * Dit wordt alleen opgeroepen als personage een cylon is
         */
        public void ExterminateCylon(String naam)
        {
            String sql = "delete from personages where (Naam = @naam)";

            MySqlCommand command = new MySqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@naam", naam);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }
}
}
