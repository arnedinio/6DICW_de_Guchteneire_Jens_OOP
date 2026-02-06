using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wielertenue
{
    public partial class BestellingForm : Form
    {
        private BestellingWielertenue _bestelling; 

        public BestellingForm()
        {
            InitializeComponent();
            _bestelling = new BestellingWielertenue(1, false, false, false);
            textBox2.Text = _bestelling.geefPrijs().ToString("0.00");
            wielertenuePictureBox.Visible = false;
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            _bestelling.Aantal = Convert.ToInt32(numericUpDown1.Value);
            textBox2.Text = _bestelling.geefPrijs().ToString("0.00");
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            _bestelling.Broek = checkBox3.Checked;
            textBox2.Text = _bestelling.geefPrijs().ToString("0.00");
            wielertenuePictureBox.Visible = checkBox3.Checked;
            checkBox2.Visible = checkBox3.Checked;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            _bestelling.SuperZeem = checkBox4.Checked;
            textBox2.Text = _bestelling.geefPrijs().ToString("0.00");
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            _bestelling.WaterdichtZakje = checkBox2.Checked;
            textBox2.Text = _bestelling.geefPrijs().ToString("0.00");
        }

    }
}
