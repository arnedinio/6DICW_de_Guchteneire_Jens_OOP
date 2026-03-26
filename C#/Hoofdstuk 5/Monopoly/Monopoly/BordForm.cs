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
    public partial class BordForm : Form
    {
        private MonopolyStraat _straat;

        public BordForm()
        {
            InitializeComponent();
        }

        private void vak23Button_Click(object sender, EventArgs e)
        {
            _straat = new MonopolyStraat("Kortrijksestraat", "Gent", 90, 100, 250, 700, 875, 1050);
            StraatForm formulier = new StraatForm(_straat, "red");
            formulier.Show();
        }

        private void vak32Button_Click(object sender, EventArgs e)
        {
            _straat = new MonopolyStraat("Vlaanderenstraat", "Gent", 120, 150, 450, 1000, 1100, 1275);
            StraatForm formulier = new StraatForm(_straat, "green");
            formulier.Show();
        }
    }
}
