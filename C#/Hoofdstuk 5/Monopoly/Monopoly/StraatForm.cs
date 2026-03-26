using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class StraatForm : Form
    {
        private MonopolyStraat _straat;

        public StraatForm(MonopolyStraat _straat, string _straatkleur)
        {
            InitializeComponent();
            
            this._straat = _straat;

            straatTextBox.Text = _straat.Straat;
            stadTextBox.Text = _straat.Stad;

            panelVak.BackColor = Color.FromName(_straatkleur);
            UpdateBebouwingEnHuur();
        }

        private void koopHuisButton_Click(object sender, EventArgs e)
        {
            _straat.KoopHuis();

            UpdateBebouwingEnHuur();
        }

        private void koopHotelButton_Click(object sender, EventArgs e)
        {
            _straat.KoopHotel();

            UpdateBebouwingEnHuur();
        }

        private void UpdateBebouwingEnHuur()
        {
            aantalHuizenTextBox.Text = _straat.AantalHuizen.ToString();
            aantalHotelsTextBox.Text = _straat.AantalHotels.ToString();
            huurTextBox.Text = _straat.GeefHuur().ToString("C");
        }
    }
}
