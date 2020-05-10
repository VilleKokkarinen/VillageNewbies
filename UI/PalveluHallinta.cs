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
    public partial class PalveluHallinta : Form
    {
        SQL s = new SQL();
        private SQLiteConnection connection;
        private SQLiteCommand cmd;

        public PalveluHallinta()
        {
            InitializeComponent();
        }

        private void PalveluHallinta_Load(object sender, EventArgs e)
        {
           dataGridView_Palvelut.DataSource = s.returnServicesDT();
            dataGridView_Palvelut.ClearSelection();
            ClearTextboxes();
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

        private void ClearTextboxes()
        {
            textBox_PalveluID.Clear();
            comboBox_AlueID.ResetText();
            textBox_PalveluNimi.Clear();
            textBox_Kuvaus.Clear();
            textBox_Hinta.Clear();
            textBox_ALV.Clear();
        }

        private void dataGridView_Palvelut_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Palvelut.SelectedCells.Count > 0)
            {
                int index = dataGridView_Palvelut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_Palvelut.Rows[index];

                textBox_PalveluID.Text = selectedRow.Cells["palvelu_id"].Value.ToString();
                textBox_PalveluNimi.Text = selectedRow.Cells["nimi"].Value.ToString();
                textBox_Kuvaus.Text = selectedRow.Cells["kuvaus"].Value.ToString();
                textBox_Hinta.Text = selectedRow.Cells["hinta"].Value.ToString();
                textBox_ALV.Text = selectedRow.Cells["alv"].Value.ToString();
                comboBox_AlueID.Text = selectedRow.Cells["toimintaalue_id"].Value.ToString();
            }
        }

        private void btn_Lisaa_Click(object sender, EventArgs e)
        {
            if (dataGridView_Palvelut.SelectedCells.Count <= 0)
            {
                try
                {
                    string textquery = "INSERT INTO palvelu(palvelu_id,nimi,kuvaus,hinta,alv,toimintaalue_id)values('" + textBox_PalveluID.Text + "'," +
                    " '" + textBox_PalveluNimi.Text + "' , '" + textBox_Kuvaus.Text + "' , '" + textBox_Hinta.Text + "' , '" + textBox_ALV.Text +
                    "' , '" + comboBox_AlueID.Text + "')";
                    ExecuteQuery(textquery);
                    dataGridView_Palvelut.DataSource = s.returnServicesDT();
                    MessageBox.Show("Palvelu lisätty tietokantaan");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_Muokkaa_Click(object sender, EventArgs e)
        {
            if (dataGridView_Palvelut.SelectedCells.Count > 0)
            {
                try
                {
                    string textquery = "UPDATE palvelu SET nimi = '" + textBox_PalveluNimi.Text + "', kuvaus = '" + textBox_Kuvaus.Text +
                    "', hinta ='" + textBox_Hinta.Text + "', alv ='" + textBox_ALV.Text + "', toimintaalue_id ='" + comboBox_AlueID.Text +
                    "' WHERE palvelu_id = '" + textBox_PalveluID.Text + "';";
                    ExecuteQuery(textquery);
                    dataGridView_Palvelut.DataSource = s.returnServicesDT();
                    MessageBox.Show("Muokkaus onnistui");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_Poista_Click(object sender, EventArgs e)
        {
            if (dataGridView_Palvelut.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa palvelun?", "Poista", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string textquey = "DELETE FROM palvelu where palvelu_id = '" + textBox_PalveluID.Text + "'";
                    ExecuteQuery(textquey);
                    dataGridView_Palvelut.DataSource = s.returnServicesDT();
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }

        private void textBox_PalveluID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
