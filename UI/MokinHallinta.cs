using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        
    }
}
