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
    public partial class Varaukset : Form
    {
        SQL s = new SQL();
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        public Varaukset()
        {
            InitializeComponent();
        }

        private void Varaukset_Load(object sender, EventArgs e)
        {
            //s.create();
            dataGridView_Varaukset.DataSource = s.returnReservationsDT();
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

        private void button_Poista_Click(object sender, EventArgs e)
        {
            if (dataGridView_Varaukset.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa varauksen?", "Poista", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = dataGridView_Varaukset.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView_Varaukset.Rows[index];

                    string textquey = "DELETE FROM varaus where varaus_id = '" + selectedRow.Cells["varaus_id"].Value.ToString() + "'";
                    ExecuteQuery(textquey);
                    dataGridView_Varaukset.DataSource = s.returnReservationsDT();
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }

        private void dataGridView_Varaukset_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
