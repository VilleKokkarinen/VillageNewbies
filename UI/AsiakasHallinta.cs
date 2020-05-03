using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageNewbies.UI
{
    public partial class AsiakasHallinta : Form
    {
        SQL s = new SQL();
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        public AsiakasHallinta()
        {
            InitializeComponent();
        }

        private void AsiakasHallinta_Load(object sender, EventArgs e)
        {
            dataGridView_Asiakkaat.DataSource = s.returnstuff();
            dataGridView_Asiakkaat.ClearSelection();
            cleartextboxes();
        }

        private void SetConnection()
        {
            connection = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db");
        }

        private void ExecuteQuery(string textquery)
        {
            SetConnection();
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = textquery;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void cleartextboxes()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }


        private void btn_lisaa_Click(object sender, EventArgs e)
        {
            if (dataGridView_Asiakkaat.SelectedCells.Count <= 0)
            {
                try
                {
                    string textquery = "INSERT INTO asiakas(asiakas_id,etunimi,sukunimi,lahiosoite,postinro,email,puhelinnro)values('" + textBox_ID.Text + "'," +
                    " '" + textBox_Etunimi.Text + "' , '" + textBox_Sukunimi.Text + "' , '" + textBox_Osoite.Text + "' , '" + textBox_Postinro.Text +
                    "' , '" + textBox_Email.Text + "' , '" + textBox_Puhnro.Text + "')";
                    ExecuteQuery(textquery);
                    dataGridView_Asiakkaat.DataSource = s.returnstuff();
                    MessageBox.Show("Asiakas lisätty tietokantaan");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void dataGridView_Asiakkaat_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Asiakkaat.SelectedCells.Count > 0)
            {
                int index = dataGridView_Asiakkaat.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dataGridView_Asiakkaat.Rows[index];

                textBox_ID.Text = selectedrow.Cells["asiakas_id"].Value.ToString();
                textBox_Etunimi.Text = selectedrow.Cells["etunimi"].Value.ToString();
                textBox_Sukunimi.Text = selectedrow.Cells["sukunimi"].Value.ToString();
                textBox_Osoite.Text = selectedrow.Cells["lahiosoite"].Value.ToString();
                textBox_Postinro.Text = selectedrow.Cells["postinro"].Value.ToString();
                textBox_Email.Text = selectedrow.Cells["email"].Value.ToString();
                textBox_Puhnro.Text = selectedrow.Cells["puhelinnro"].Value.ToString();
            }
        }

        private void btn_muokkaa_Click(object sender, EventArgs e)
        {
            if (dataGridView_Asiakkaat.SelectedCells.Count > 0)
            {
                try
                {
                    string textquery = "UPDATE asiakas SET etunimi = '" + textBox_Etunimi.Text + "', sukunimi = '" + textBox_Sukunimi.Text +
                    "', lahiosoite ='" + textBox_Osoite.Text + "', postinro ='" + textBox_Postinro.Text + "', email ='" + textBox_Email.Text +
                    "', puhelinnro ='" + textBox_Puhnro.Text + "' WHERE asiakas_id = '" + textBox_ID.Text + "';";
                    ExecuteQuery(textquery);
                    dataGridView_Asiakkaat.DataSource = s.returnstuff();
                    MessageBox.Show("Muokkaus onnistui");
                }
                catch (Exception error)
                {

                    throw;
                }
            }
        }

        private void btn_poista_Click(object sender, EventArgs e)
        {
            if (dataGridView_Asiakkaat.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa asiakkaan?", "Poista", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string textquey = "DELETE FROM asiakas where asiakas_id = '" + textBox_ID.Text + "'";
                    ExecuteQuery(textquey);
                    dataGridView_Asiakkaat.DataSource = s.returnstuff();
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }
    }
}
