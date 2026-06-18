namespace Business
{
    public class Schip
    {
        //Velden
        private int _id;
        private String _naam;
        private String _type;
        private int _bouwjaar;
        private int _aantalBemanning;
        private String _status;

        //Ik weet dat we auto properties niet geleerd hebben, maar ik heb dit gisteren ontdekt en wil het gebruikenm
        
        //Constructor
        public Schip(int id, string naam, string type, int bouwjaar, int aantalBemanning, string status)
        {
            Id = id;
            Naam = naam;
            Type = type;
            Bouwjaar = bouwjaar;
            AantalBemanning = aantalBemanning;
            Status = status;
        }

        //(auto-)Properties
        public int Id { get; set; }
        public String Naam { get; set; }
        public String Type { get; set; }
        public int Bouwjaar { get; set; }
        public int AantalBemanning { get; set; }
        public String Status { get; set; }
    }
}
