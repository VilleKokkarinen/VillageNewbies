using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageNewbies.UI
{
    public partial class MokinHallinta : Form
    {
        SQL s = new SQL();
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        public MokinHallinta()
        {
            InitializeComponent();
        }

        private void MokinHallinta_Load(object sender, EventArgs e)
        {

            dataGrid_Mokit.DataSource = s.returnCabinsDT();
            dataGrid_Mokit.ClearSelection();
            clear_txt_boxes();
        }

        private void clear_txt_boxes()
        {
            textBox_MokkiID.Clear();
            textBox_Alue.Clear();
            textBox_PostiNro.Clear();
            textBox_Osoite.Clear();
            textBox_MokinNimi.Clear();
            textBox_Varustelu.Clear();
            textBox6_Maara.Clear();
            textBox_Kuvaus.Clear();
        }

        private void dataGrid_Mokit_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGrid_Mokit.SelectedCells.Count > 0)
            {
                int index = dataGrid_Mokit.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGrid_Mokit.Rows[index];

                textBox_MokkiID.Text = selectedRow.Cells["mokki_id"].Value.ToString();
                textBox_Alue.Text = selectedRow.Cells["toimintaalue_id"].Value.ToString();
                textBox_PostiNro.Text = selectedRow.Cells["postinro"].Value.ToString();
                textBox_Osoite.Text = selectedRow.Cells["katuosoite"].Value.ToString();
                textBox_MokinNimi.Text = selectedRow.Cells["mokkinimi"].Value.ToString();
                textBox_Kuvaus.Text = selectedRow.Cells["kuvaus"].Value.ToString();
                textBox6_Maara.Text = selectedRow.Cells["henkilomaara"].Value.ToString();
                textBox_Varustelu.Text = selectedRow.Cells["varustelu"].Value.ToString();
            }

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

        private void btn_Lisaa_Click(object sender, EventArgs e)
        {
            SQL s = new SQL();
            if (dataGrid_Mokit.SelectedCells.Count <= 0)
            {
                try
                {
                    string textquery = "INSERT INTO mokki(mokki_id,toimintaalue_id,postinro,katuosoite,mokkinimi,kuvaus,varustelu,henkilomaara)values('" + textBox_MokkiID.Text + "'," +
                    " '" + textBox_Alue.Text + "' , '" + textBox_PostiNro.Text + "' , '" + textBox_Osoite.Text + "' , '" + textBox_MokinNimi.Text +
                    "' , '" + textBox_Kuvaus.Text + "' , '" + textBox_Varustelu.Text + "' , '" + textBox6_Maara.Text + "')";
                    ExecuteQuery(textquery);
                    dataGrid_Mokit.DataSource = s.returnCabinsDT();
                    MessageBox.Show("Mökki lisätty tietokantaan");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_Muokkaa_Click(object sender, EventArgs e)
        {
            SQL s = new SQL();
            if (dataGrid_Mokit.SelectedCells.Count > 0)
            {
                try
                {
                    string textquery = "UPDATE mokki SET postinro = '" + textBox_PostiNro.Text + "', toimintaalue_id = '" + textBox_Alue.Text +
                    "', katuosoite ='" + textBox_Osoite.Text + "', mokkinimi ='" + textBox_MokinNimi.Text + "', kuvaus ='" + textBox_Kuvaus.Text +
                    "', henkilomaara ='" + textBox6_Maara.Text + "', varustelu ='" + textBox_Varustelu.Text + "' WHERE mokki_id = '" + textBox_MokkiID.Text + "';";
                    ExecuteQuery(textquery);
                    dataGrid_Mokit.DataSource = s.returnCabinsDT();
                    MessageBox.Show("Muokkaus onnistui");
                }
                catch (Exception error)
                {

                    throw;
                }
            }
        }

        private void btn_Poista_Click(object sender, EventArgs e)
        {
            if (dataGrid_Mokit.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa mökin?", "Poista", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string textquey = "DELETE FROM mokki where mokki_id = '" + textBox_MokkiID.Text + "'";
                    ExecuteQuery(textquey);
                    dataGrid_Mokit.DataSource = s.returnCabinsDT();
                }
                else if (result == DialogResult.No)
                {
                   
                }
            }
        }
    }
}
