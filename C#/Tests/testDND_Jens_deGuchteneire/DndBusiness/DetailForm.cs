using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndBusiness
{
    public partial class DetailForm : Form
    {
        public DetailForm(Karakter k)
        {
            InitializeComponent();
            if (k == null)
            {
                this.naamLabel.Text = string.Empty;
                this.sterkteLabel.Text = string.Empty;
                this.naamInputLabel.Text = "Dit karakter bestaat al.";
                this.sterkteInputLabel.Text = string.Empty;
            }
            else
            {
                this.naamLabel.Text = "Naam:";
                this.naamInputLabel.Text = k.Naam.ToString();
                this.sterkteLabel.Text = "Sterkte:";
                this.sterkteInputLabel.Text = k.Sterkte.ToString();
            }
        }

    }
}
