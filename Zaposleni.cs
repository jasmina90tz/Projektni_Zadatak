using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projektni_Zadatak
{
    public partial class Zaposleni : Form
    {
        private int i;

        public Zaposleni()
        {
            InitializeComponent();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c: \users\korisnik\documents\visual studio 2015\Projects\Projektni Zadatak\Projektni Zadatak\MyDBTest.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void Zaposleni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this.myDBDataSet.Zaposlenici);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {

            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\korisnik\documents\visual studio 2015\Projects\Projektni Zadatak\Projektni Zadatak\MyDBTest.mdf;Integrated Security=True;Connect Timeout=30");
            sc.Open();
            string query = "Insert into Zaposlenici table values(@Šifra,@Prezime, @Ime, @Pol, @Grad, @Adresa)";
            SqlCommand sm = new SqlCommand(query, sc);
            sm.Parameters.AddWithValue("@Šifra", šifraTextBox);
            sm.Parameters.AddWithValue("@Prezime", prezimeTextBox);
            sm.Parameters.AddWithValue("@Ime", imeTextBox);
            sm.Parameters.AddWithValue("@Pol", polComboBox);
            sm.Parameters.AddWithValue("@Grad", gradTextBox);
            sm.Parameters.AddWithValue("@Adresa", adresaTextBox);
            sm.Parameters.AddWithValue("@DatumDodavanja", datumDodavanja);
            sm.Parameters.AddWithValue("@DatumIzmjene", datumIzmjene);

            sc.Close();
            MessageBox.Show("Zaposlenik uspješno dodan");
            {
                try
                {
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void polComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void home_Click(object sender, EventArgs e)
        {
            new HR().Show();
            this.Hide();
        }

        private void zaposleniciBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\korisnik\documents\visual studio 2015\Projects\Projektni Zadatak\Projektni Zadatak\MyDBTest.mdf;Integrated Security=True;Connect Timeout=30");
            
        }

        private void ZaposleniDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void edit_Click(object sender, EventArgs e)
        {
            
            }
    }
}
   


