using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projektni_Zadatak
{
    public partial class Tok : Form
    {
        public Tok()
        {
            InitializeComponent();
        }

        private void Tok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this.myDBDataSet.Zaposlenici);
            // TODO: This line of code loads data into the 'myDBDataSet.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this.myDBDataSet.Zaposlenici);
            // TODO: This line of code loads data into the 'myDBDataSet.Zaposlenicic_Događaji' table. You can move, or remove it, as needed.
            this.zaposlenicic_DogađajiTableAdapter.Fill(this.myDBDataSet.Zaposlenicic_Događaji);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            
        }

        private void home_Click(object sender, EventArgs e)
        {
            new HR().Show();
            this.Hide();
        }
    }
}
