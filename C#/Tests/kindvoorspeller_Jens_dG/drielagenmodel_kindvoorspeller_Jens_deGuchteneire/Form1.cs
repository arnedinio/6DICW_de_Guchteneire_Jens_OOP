namespace drielagenmodel_kindvoorspeller_Jens_deGuchteneire
{
    public partial class Form1 : Form
    {
        private KindLengteVoorspeller _voorspeller;
        
        public Form1()
        {
            InitializeComponent();
            _voorspeller = new KindLengteVoorspeller();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                _voorspeller.LengteVrouw = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                _voorspeller.LengteVrouw = 0;
            }   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            _voorspeller.LengteMan = Convert.ToDouble(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = _voorspeller.BerekenDochter().ToString("0.00");
            _voorspeller.AantalVoorspellingen = _voorspeller.AantalVoorspellingen += 1;
            label3.Text = _voorspeller.AantalVoorspellingen.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = _voorspeller.BerekenZoon().ToString("0.00");
            _voorspeller.AantalVoorspellingen = _voorspeller.AantalVoorspellingen += 1;
            label3.Text = _voorspeller.AantalVoorspellingen.ToString();
        }

    }
}
