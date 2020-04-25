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
    public partial class Varaus : Form
    {
        public Varaus()
        {
            InitializeComponent();
        }

 
            
        

        private void Varaus_Load(object sender, EventArgs e)
        {
            SQL s = new SQL();
            s.create();

            /*
             * Tapa 1
             */
            List<Cabin> dataa = SQL.GetAllCabins();
            foreach (Cabin i in dataa)
            {
                checklist_Loan_Cabins.Items.Add(i);
                checklist_Loan_Cabins.DisplayMember = i.mokkinimi;
            }

            dataGridView1.DataSource = s.returnstuff();

            /*
             * Tapa 2
             * 
             */
            List<DataRow> dataa2 = s.SQLiteQuery_DT_List(
                "SELECT * FROM mokki");

            foreach (DataRow i in dataa2)
            {
                Cabin c = new Cabin(
                    Convert.ToInt32(i[0].ToString()), // <-> i["mokki_id"]
                    Convert.ToInt32(i[1].ToString()),
                    i[2].ToString(),
                    i[3].ToString(),
                    i[4].ToString(),
                    i[5].ToString(),
                    Convert.ToInt32(i[6].ToString()),
                    i[7].ToString()
                    );
                    
                checklist_Loan_Cabins.Items.Add(c);
                checklist_Loan_Cabins.DisplayMember = "DISPLAYNAME";
            }

            dataGridView1.DataSource = s.returnstuff();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];

                txtboxAsiakas_id.Text = selectedRow.Cells["asiakas_id"].Value.ToString();
                txtboxEtunimi.Text = selectedRow.Cells["etunimi"].Value.ToString();
                txtboxSukunimi.Text = selectedRow.Cells["sukunimi"].Value.ToString();
                txtboxPostinro.Text = selectedRow.Cells["postinro"].Value.ToString();
                txtboxlahiosoite.Text = selectedRow.Cells["lahiosoite"].Value.ToString();
                txtboxEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txtboxPuhelinnro.Text = selectedRow.Cells["puhelinnro"].Value.ToString();
            }
        }

        /// <summary>
        /// chekkilistan valinta vaihtuu -> syötä tietoja textiboxiin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checklist_Loan_Cabins_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Cabin_Type.Text = ((Cabin)checklist_Loan_Cabins.SelectedItem).toimintaalue_id.ToString();
        }
    }
}
