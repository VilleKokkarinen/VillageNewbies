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
    public partial class Laskut : Form
    {
        SQL s = new SQL();
        public Laskut()
        {
            InitializeComponent();
        }

        private void Laskut_Load(object sender, EventArgs e)
        {
            dataGridView_laskut.DataSource = s.returnInvoicesDT();
            dataGridView_laskut.ClearSelection();
        }

        private void dataGridView_laskut_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_laskut.SelectedCells.Count > 0)
            {
                int index = dataGridView_laskut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dataGridView_laskut.Rows[index];

                textBox_LaskuID.Text = selectedrow.Cells["lasku_id"].Value.ToString();
                textBox_VarausID.Text = selectedrow.Cells["varaus_id"].Value.ToString();
                textBox_Summa.Text = selectedrow.Cells["summa"].Value.ToString();
                textBox_ALV.Text = selectedrow.Cells["alv"].Value.ToString();
            }
        }

        private void Btn_Poista_Click(object sender, EventArgs e)
        {
            if (dataGridView_laskut.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa asiakkaan?", "Poista", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
                    {
                        connect.Open();
                        using (SQLiteCommand fmd = connect.CreateCommand())
                        {

                            string CommandText = "DELETE FROM lasku WHERE lasku_id = '" + textBox_LaskuID.Text + "'";
                            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, connect);

                            DataTable dt;

                            using (dt = new DataTable())
                            {
                                sqlda.Fill(dt);
                                dataGridView_laskut.DataSource = dt;
                            }
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Asiakasta ei poistettu!!");
                }
            }
            dataGridView_laskut.DataSource = s.returnInvoicesDT();
        }
    }
}
