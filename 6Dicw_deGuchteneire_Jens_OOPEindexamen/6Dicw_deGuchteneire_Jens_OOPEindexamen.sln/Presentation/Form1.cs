using System.Drawing.Text;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class Form1 : Form
    {
        //De booleans waren voor mijn origineel plan om bij herlaad data alleen de al geladen data te herladen.
        //Ik ga het laten om denkprocess te tonen

        //Velden
        private BSGData _data;
        private bool _personagesGeladen;
        private bool _planeten;
        private bool _vloot;
        private List<Personage> _personages; //Lijst van personages om later cylon te checken

        //Constructor
        public Form1()
        {
            InitializeComponent();
            _data = new BSGData();

            _personagesGeladen = false;
            _planeten = false;
            _vloot = false;

            _personages = new List<Personage>();

            exterminateButton.Visible = false;
        }

        /*
         * Laad alle data van personages naar personagesDataGridView
         */
        private void personagesButton_Click(object sender, EventArgs e)
        {
            _personagesGeladen = true;
            _personages = _data.GeefPersonages();

            personagesDataGridView.Columns.Clear();
            personagesDataGridView.Columns.Add("Naam", "Naam");
            personagesDataGridView.Columns.Add("Rol", "Rol");
            personagesDataGridView.Columns.Add("Leeftijd", "Leeftijd");

            foreach (var personage in _personages)
            {
                personagesDataGridView.Rows.Add(personage.Naam, personage.Rol, personage.Leeftijd);
            }
        }

        /*
         * Laad alle data van de schepen in de vlootDataGridView bij klikken
         */
        private void vlootButton_Click(object sender, EventArgs e)
        {
            _vloot = true;
            List<Schip> schepen = _data.GeefSchepen();

            vlootDataGridView.Columns.Clear();
            vlootDataGridView.Columns.Add("Naam", "Naam");
            vlootDataGridView.Columns.Add("Type", "Type");
            vlootDataGridView.Columns.Add("Bouwjaar", "Bouwjaar");
            vlootDataGridView.Columns.Add("AantalBemanning", "AantalBemanning");
            vlootDataGridView.Columns.Add("Status", "Status");

            foreach (var schip in schepen)
            {
                vlootDataGridView.Rows.Add(schip.Naam, schip.Type, schip.Bouwjaar, schip.AantalBemanning, schip.Status);
            }
        }

        /*
         * Laad alle data van planeten in planetenDataGridView bij klikken
         */
        private void planetenButton_Click(object sender, EventArgs e)
        {
            _planeten = true;
            List<Planeet> planeten = _data.GeefPlaneten();

            planetenDataGridView.Columns.Clear();
            planetenDataGridView.Columns.Add("Naam", "Naam");
            planetenDataGridView.Columns.Add("Zonnestelsel", "Zonnestelsel");
            planetenDataGridView.Columns.Add("Bewoonbaar", "Bewoonbaar");
            planetenDataGridView.Columns.Add("Liter Water", "Liter Water");

            foreach (var planeet in planeten)
            {
                planetenDataGridView.Rows.Add(planeet.Naam, planeet.Zonnestelsel, planeet.Woonbaar, planeet.LiterWater);
            }
        }

        /*
         * Functie die alle data van planeten, personages en schepen laad in hun respectievelijke DataGridViews bij klikken
         * Verandert kleur van label terug naar standaard
         */
        private void herlaadButton_Click(object sender, EventArgs e)
        {
            planetenButton_Click(sender, e);
            vlootButton_Click(sender, e);
            personagesButton_Click(sender, e);
            label.ForeColor = Color.Snow;
        }


        /*
         * Functie bekijkt de geselecteerde rij in de personages DataGridView, als er een selectie is bij klikken
         * Verandert de kleur van de label naar rood bij een cylon, en naar groen bij een mens
         */
        private void detectorButton_Click(object sender, EventArgs e)
        {
            if (personagesDataGridView.SelectedRows.Count > 0)
            {
                //Dit had ik nooit gevonden! Dankje, Gaius
                String strSelectie = personagesDataGridView.SelectedRows[0].Cells[0].FormattedValue.ToString();
                foreach (var personage in _personages)
                {
                    if (personage.Naam.Equals(strSelectie))
                    {
                        if (personage.IsCylon)
                        {
                            label.ForeColor = Color.Red;
                            exterminateButton.Visible = true;
                        }
                        else
                        {
                            label.ForeColor = Color.Green;
                            exterminateButton.Visible = false;
                        }
                    }
                }
            }


        }

        /*
         * Roept functie op om geselcteerde cylon te verwijderen uit de databank
         * Als geselcteerde persoon veranderd is, en de geen cylon is, word die niet verwijderd.
         * Number Six is al een voorbeeld van gemaakt wegens het verleiden van Gaius
         */
        private void exterminateButton_Click(object sender, EventArgs e)
        {
            bool isCylon = false;
            String strSelectie = personagesDataGridView.SelectedRows[0].Cells[0].FormattedValue.ToString();

            foreach (var personage in _personages)
            {
                if (personage.Naam.Equals(strSelectie))
                {
                    if (personage.IsCylon)
                    {
                        isCylon = true;
                    }
                }
            }

            _data.ExterminateCylon(strSelectie);

            herlaadButton_Click(sender, e);
        }
    }
}
