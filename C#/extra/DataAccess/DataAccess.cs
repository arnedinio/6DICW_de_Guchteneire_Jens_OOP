namespace DataAccess
{
    public class DataAccess
    {
        public List<HighScore> ReadTable()
        {
            List<HighScore> lijst = new List<HighScore>();

            String sql = "SELECT * FROM high_scores ORDER BY Naam;";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                HighScore highScore =
                    new HighScore((int)(mySqlDataReader["ID"]),
                        mySqlDataReader["Naam"].ToString(),
                        (int)(mySqlDataReader["High_Score"]));

                lijst.Add(highScore);
            }

            _mySqlConnection.Close();

            return lijst;
        }
    }
}
