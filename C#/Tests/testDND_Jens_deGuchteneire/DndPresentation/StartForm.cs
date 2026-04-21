using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DndBusiness;

namespace DndPresentation
{
    public partial class StartForm : Form
    {
        //Velden
        private DnD _dnd;
        public StartForm()
        {
            InitializeComponent();
            this._dnd = new DnD();
        }

        private void voegToeButton_Click(object sender, EventArgs e)
        {
            _dnd.VoegToe(naamTextBox.Text, Convert.ToInt32(sterkteTextBox.Text));
            karakterComboBox.DataSource = _dnd.Karakters;
            //Refresht niet bij meerdere karakters????
        }

        private void toonFormButton_Click(object sender, EventArgs e)
        {
            Karakter k = (Karakter)karakterComboBox.SelectedItem;
            DetailForm form = new DetailForm(k);
            form.Show();
        }

        private void toonHierButton_Click(object sender, EventArgs e)
        {
            Karakter k = (Karakter)karakterComboBox.SelectedItem;
            toonHierLabel.Text = "Naam: " + k.Naam + " Sterkte: " + k.Sterkte;
        }
    }
}
