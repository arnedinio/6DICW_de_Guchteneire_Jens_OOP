using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;

namespace Presentation
{
    public partial class CocktailInfoForm : Form
    {
        private Cocktail _cocktail;

        public void RefreshUI()
        {
            naamTextBox.Text = _cocktail.Naam;
            kostprijsTextBox.Text = _cocktail.Kostprijs.ToString("C");
            inhoudTextBox.Text = _cocktail.InhoudCocktail().ToString();
            alcoholpercentageTextBox.Text = _cocktail.Alcoholpercentage().ToString("P0");
            ingredientenListBox.DataSource = null;
            ingredientenListBox.DataSource = _cocktail.AlcoholischeIngredienten();
            listBox1.DataSource = _cocktail.NietAlcoholischeIngredienten();
        }

        public CocktailInfoForm(Cocktail cocktail)
        {
            InitializeComponent();

            _cocktail = cocktail;

            RefreshUI();
        }
        
        private void toonButton_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = (Ingredient)ingredientenListBox.SelectedItem;
            IngredientForm form = new IngredientForm(ingredient);
            form.Show();
        }

        private void pittigerButton_Click(object sender, EventArgs e)
        {
            _cocktail.MaakPittiger();
            RefreshUI();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = (Ingredient)listBox1.SelectedItem;
            IngredientForm form = new IngredientForm(ingredient);
            form.Show();
        }
    }
}
