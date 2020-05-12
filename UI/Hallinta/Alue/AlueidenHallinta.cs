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
    public partial class AlueidenHallinta : Form
    {
        SQL s = new SQL();
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        public AlueidenHallinta()
        {
            InitializeComponent();
        }

        private void AlueidenHallinta_Load(object sender, EventArgs e)
        {
            dataGridView_Alueet.DataSource = s.returnAreasDT();
            dataGridView_Alueet.ClearSelection();
            ClearTextboxes();
        }

        private void SetConnection()
        {
            connection = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db");
        }

        private void executequery(string textquery)
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
            textBox_AlueID.Clear();
            textBox_Nimi.Clear();
        }

        private void dataGridView_Alueet_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Alueet.SelectedCells.Count > 0)
            {
                int index = dataGridView_Alueet.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dataGridView_Alueet.Rows[index];

                textBox_AlueID.Text = selectedrow.Cells["toimintaalue_id"].Value.ToString();
                textBox_Nimi.Text = selectedrow.Cells["nimi"].Value.ToString();
            }
        }

        private void button_Lisaa_Click(object sender, EventArgs e)
        {
            if (dataGridView_Alueet.SelectedCells.Count <= 0)
            {
                try
                {
                    string textquery = "INSERT INTO toimintaalue(toimintaalue_id,nimi)values('" + textBox_AlueID.Text + "'," +
                    " '" + textBox_Nimi.Text + "')";
                    executequery(textquery);
                    dataGridView_Alueet.DataSource = s.returnAreasDT();
                    MessageBox.Show("Alue lisätty tietokantaan");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void button_Muokka_Click(object sender, EventArgs e)
        {
            if (dataGridView_Alueet.SelectedCells.Count > 0)
            {
                try
                {
                    string textquery = "UPDATE toimintaalue SET nimi = '" + textBox_Nimi.Text +
                    "' WHERE toimintaalue_id = '" + textBox_AlueID.Text + "';";
                    executequery(textquery);
                    dataGridView_Alueet.DataSource = s.returnAreasDT();
                    MessageBox.Show("Muokkaus onnistui");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void button_Poista_Click(object sender, EventArgs e)
        {
            if (dataGridView_Alueet.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa alueen?", "Poista", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string textquey = "DELETE FROM toimintaalue where toimintaalue_id = '" + textBox_AlueID.Text + "'";
                    executequery(textquey);
                    dataGridView_Alueet.DataSource = s.returnAreasDT();
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }

        private void textBox_AlueID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
