using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wekker
{
    public partial class Wekkerform : Form
    {
        private Wekker _wekker;
        public Wekkerform()
        {
            InitializeComponent();

            _wekker = new Wekker();

            alarmOmTextBox.Text = _wekker.AlarmOm();
        }

        private void uurOmhoogButton_Click(object sender, EventArgs e)
        {
            _wekker.UrenPlus();

            alarmOmTextBox.Text = _wekker.AlarmOm();
        }

        private void uurOmlaagButton_Click(object sender, EventArgs e)
        {
            _wekker.UrenMin();

            alarmOmTextBox.Text = _wekker.AlarmOm();
        }

        private void minuutOmhoogButton_Click(object sender, EventArgs   e)
        {
            _wekker.MinutenPlus();

            alarmOmTextBox.Text = _wekker.AlarmOm();
        }

        private void minuutOmlaagButton_Click(object sender, EventArgs e)
        {
            _wekker.MinutenMin();

            alarmOmTextBox.Text = _wekker.AlarmOm();
        }
    }
}
