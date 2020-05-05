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
    public partial class Varaus : Form
    {
        public Varaus()
        {
            InitializeComponent();
           
        }

        private SQLiteConnection connection;
        private SQLiteCommand cmd;

        private BindingList<Cabin> Mokit;
        private BindingList<Cabin> NakyvatMokit;

        private void Varaus_Load(object sender, EventArgs e)
        {
            Mokit = new BindingList<Cabin>();
            NakyvatMokit = new BindingList<Cabin>();

            SQL s = new SQL();
            //s.create();
            checklist_Loan_Cabins.DataSource = NakyvatMokit;
            checklist_Loan_Cabins.DisplayMember = "DISPLAYNAME";

            List<DataRow> dataa2 = s.SQLiteQuery_DataRowList(
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
                   i[8].ToString(),
                   Convert.ToInt32(i[7].ToString())
                   );
                Mokit.Add(c);
                NakyvatMokit.Add(c);
            }


            List<Service> palveludata = SQL.GetAllServices();
            foreach (Service i in palveludata)
            {
                Clb_Palvelut.Items.Add(i);
                Clb_Palvelut.DisplayMember = "DISPLAYNAME";
            }

            dataGridView1.DataSource = s.returnstuff();

            dataGridView1.ClearSelection();
            clear_txt_boxes();

            List<DataRow> alueet = s.SQLiteQuery_DataRowList("Select * from toimintaalue");
            combobox_Cabin_Region.Items.Add("<kaikki>");
            foreach (DataRow i in alueet)
            {
                OperatingArea oa = new OperatingArea(

                    Convert.ToInt32(i[0].ToString()),
                    i[1].ToString()
                    );
                combobox_Cabin_Region.Items.Add(oa);
                combobox_Cabin_Region.DisplayMember = "DISPLAYNAME";
            }
            naytavaratutmokit();
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
            if(checklist_Loan_Cabins.SelectedItem != null)
            {
                txt_Cabin_MaxResidents.Text = ((Cabin)checklist_Loan_Cabins.SelectedItem).henkilomaara.ToString();
                txt_Cabin_Details.Text = ((Cabin)checklist_Loan_Cabins.SelectedItem).kuvaus;
                txt_Cabin_Price.Text = ((Cabin)checklist_Loan_Cabins.SelectedItem).hinta.ToString();
                txt_Cabin_State.Text = ((Cabin)checklist_Loan_Cabins.SelectedItem).varattu == true ? "varattu" : "avoin";
            }
           
        }

        private void checklist_Loan_Cabins_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checklist_Loan_Cabins.CheckedItems.Count > 0)
            {
                checklist_Loan_Cabins.ItemCheck -= checklist_Loan_Cabins_ItemCheck;
                checklist_Loan_Cabins.SetItemChecked(checklist_Loan_Cabins.CheckedIndices[0], false);
                checklist_Loan_Cabins.ItemCheck += checklist_Loan_Cabins_ItemCheck;
            }
        }

        private void combobox_Cabin_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            NakyvatMokit.Clear();

            foreach(Cabin c in Mokit)
            {
                if(c.toimintaalue_id == ((OperatingArea)combobox_Cabin_Region.SelectedItem).toimintaalue_id)
                {
                    NakyvatMokit.Add(c);
                }
            }

            if(combobox_Cabin_Region.SelectedItem.ToString() == "<kaikki>")
            {
                NakyvatMokit = Mokit;
            }
            
        }

        private void txt_Cabin_Search_Name_TextChanged(object sender, EventArgs e)
        {
            checklist_Loan_Cabins.Items.Clear();
            SQL s = new SQL();
            string query = "SELECT * FROM mokki";


            if (txt_Cabin_Search_Name.Text != null)
                query = "SELECT * FROM mokki where mokki.mokkinimi LIKE '%" + txt_Cabin_Search_Name.Text + "%'";


            List<DataRow> dataa2 = s.SQLiteQuery_DataRowList(query);
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
                   i[8].ToString(),
                   Convert.ToInt32(i[7].ToString())
                   );

                checklist_Loan_Cabins.Items.Add(c);
                checklist_Loan_Cabins.DisplayMember = "DISPLAYNAME";
            }
        }
        private void clear_txt_boxes()
        {
            txtboxAsiakas_id.Clear();
            txtboxEtunimi.Clear();
            txtboxSukunimi.Clear();
            txtboxPostinro.Clear();
            txtboxlahiosoite.Clear();
            txtboxEmail.Clear(); 
            txtboxPuhelinnro.Clear();
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


        private void buttonLisääMuokkaa_Click(object sender, EventArgs e)
        {
            SQL s = new SQL();
            if (dataGridView1.SelectedCells.Count <= 0)
            {
                try
                {
                    string textquery = "INSERT INTO asiakas(asiakas_id,postinro,etunimi,sukunimi,lahiosoite,email,puhelinnro)values('" + txtboxAsiakas_id.Text + "'," +
                    " '" + txtboxPostinro.Text + "' , '" + txtboxEtunimi.Text + "' , '" + txtboxSukunimi.Text + "' , '" + txtboxlahiosoite.Text +
                    "' , '" + @txtboxEmail.Text + "' , '" + txtboxPuhelinnro.Text + "')";
                    ExecuteQuery(textquery);
                    dataGridView1.DataSource = s.returnstuff();
                    MessageBox.Show("Lisäys onnistui");
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                try
                {
                    string textquery = "UPDATE asiakas SET postinro = '" + txtboxPostinro.Text + "', etunimi = '" + txtboxEtunimi.Text +
                    "', sukunimi ='" + txtboxSukunimi.Text + "', lahiosoite ='" + txtboxlahiosoite.Text + "', email ='" + txtboxEmail.Text +
                    "', puhelinnro ='" + txtboxPuhelinnro.Text + "' WHERE asiakas_id = '" + txtboxAsiakas_id.Text + "';";
                    ExecuteQuery(textquery);
                    dataGridView1.DataSource = s.returnstuff();
                    MessageBox.Show("Muokkaus onnistui");
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void naytavaratutmokit()
        {
            if (check_Cabin_Show_Reserved.Checked == false)
            {
                NakyvatMokit.Clear();

                foreach (Cabin c in Mokit)
                {
                    if (c.varattu == false)
                    {
                        NakyvatMokit.Add(c);
                    }
                }
            }
            else
            {
                NakyvatMokit.Clear();
                foreach (Cabin c in Mokit)
                {
                    NakyvatMokit.Add(c);
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            naytavaratutmokit();
        }

        public static long ConvertToUnixTime(DateTime datetime)
        {
            DateTime sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            return (long)(datetime - sTime).TotalSeconds;
        }

        private void Btn_Varaa_Click(object sender, EventArgs e)
        {            
            string textquery = $"INSERT INTO varaus(asiakas_id,mokki_id,varattu_pvm,vahvistus_pvm,varattu_alkupvm,varattu_loppupvm)values(" +
                $"{txtboxAsiakas_id.Text}, {((Cabin)checklist_Loan_Cabins.SelectedItem).mokki_id}, date('now'), date('now'), {ConvertToUnixTime(dateTimePicker1.Value)}, {ConvertToUnixTime(dateTimePicker2.Value)})";


            ExecuteQuery(textquery);
            MessageBox.Show("Lisäys onnistui");
            Lasku lasku = new Lasku();
            lasku.Show();
            
        }

        private void comboBox_HenkMaara_SelectedIndexChanged(object sender, EventArgs e)
        {
            NakyvatMokit.Clear();

            foreach (Cabin c in Mokit)
            {
                if (c.henkilomaara >= int.Parse(comboBox_HenkMaara.Text))
                {
                    NakyvatMokit.Add(c);
                }
            }
        }
    }
}
