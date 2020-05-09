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
            Buttonvaraa();
        }

        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        SQLiteDataAdapter adapt;
        DataTable dt;

        private BindingList<Cabin> Mokit;
        private BindingList<Cabin> NakyvatMokit;

        private BindingList<Reservation> Varaukset;
        private BindingList<Service> palvelut;
        private BindingList<Service> valitutpalvelut;

        private void Varaus_Load(object sender, EventArgs e)
        {
            Mokit = new BindingList<Cabin>();
            NakyvatMokit = new BindingList<Cabin>();
            palvelut = new BindingList<Service>();
            valitutpalvelut = new BindingList<Service>();

            Varaukset = new BindingList<Reservation>();

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


            List<DataRow> varausdata = s.SQLiteQuery_DataRowList(
                "SELECT * FROM varaus");

            foreach (DataRow i in varausdata)
            {
                Reservation r = new Reservation(
                   Convert.ToInt32(i[0].ToString()), // <-> i["varaus_id"]
                   Convert.ToInt32(i[1].ToString()),
                   Convert.ToInt32(i[2].ToString()),
                   Convert.ToInt32(i[3].ToString()),
                   Convert.ToInt32(i[4].ToString()),
                   Convert.ToInt32(i[5].ToString()),
                   Convert.ToInt32(i[6].ToString())
                   );
                Varaukset.Add(r);
            }

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
                textBox_PostiToimiPaikka.Text = selectedRow.Cells["postitoimipaikka"].Value.ToString();
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
            if (checklist_Loan_Cabins.SelectedItem != null)
            {
                dateTimePicker_Lahto = new DateTimePicker();
                dateTimePicker_Tulo = new DateTimePicker();

                txt_Cabin_MaxResidents.Text = ((Cabin)checklist_Loan_Cabins.SelectedItem).henkilomaara.ToString();
                txt_Cabin_Details.Text = ((Cabin)checklist_Loan_Cabins.SelectedItem).kuvaus;
                txt_Cabin_Price.Text = ((Cabin)checklist_Loan_Cabins.SelectedItem).hinta.ToString();
                txt_Cabin_State.Text = ((Cabin)checklist_Loan_Cabins.SelectedItem).varattu == true ? "varattu" : "avoin";
                
                /*
                if(((Cabin)checklist_Loan_Cabins.SelectedItem).varattu == false)
                {
                    List<DateTime> lista = new List<DateTime>();

                    //PVM blokkaus
                    List<DataRow> paivat = new SQL().SQLiteQuery_DataRowList(
                    "SELECT varattu_alkupvm, varattu_loppupvm FROM varaus WHERE varaus.mokki_id = " + ((Cabin)checklist_Loan_Cabins.SelectedItem).mokki_id
                    + " AND varaus.varattu_loppupvm > strftime('%s', 'now')");


                    foreach (DataRow i in paivat)
                    {
                        lista.Add(UnixTimeStampToDateTime(Convert.ToDouble(i[0].ToString())));
                    }

                    if (lista.Count != 0)
                    {
                        dateTimePicker_Lahto.MaxDate = lista.Min().Subtract(new TimeSpan(24, 0, 0));
                        dateTimePicker_Tulo.MaxDate = dateTimePicker_Lahto.MaxDate;
                        dateTimePicker_Tulo.MinDate = DateTime.Now;
                        dateTimePicker_Lahto.MinDate = DateTime.Now.AddDays(1);
                        lista.Clear();
                    }
                    else
                    {
                        dateTimePicker_Tulo.MaxDate = DateTime.Now.AddDays(90);
                        dateTimePicker_Tulo.MinDate = DateTime.Now;

                        dateTimePicker_Lahto.MaxDate = DateTime.Now.AddDays(91);
                        dateTimePicker_Lahto.MinDate = DateTime.Now.AddDays(1);
                        
                    }
                }
                else
                {
                    List<DateTime> lista = new List<DateTime>();

                    //PVM blokkaus
                    List<DataRow> paivat = new SQL().SQLiteQuery_DataRowList(
                    "SELECT varattu_loppupvm FROM varaus WHERE varaus.mokki_id = " + ((Cabin)checklist_Loan_Cabins.SelectedItem).mokki_id
                    + " AND varaus.varattu_loppupvm > strftime('%s', 'now') AND varaus.varattu_alkupvm < strftime('%s', 'now')");

                    List<DateTime> lista2 = new List<DateTime>();
                    List<DateTime> lista3 = new List<DateTime>();

                    //PVM blokkaus
                    List<DataRow> paivat2 = new SQL().SQLiteQuery_DataRowList(
                    "SELECT varattu_loppupvm, varattu_alkupvm FROM varaus WHERE varaus.mokki_id = " + ((Cabin)checklist_Loan_Cabins.SelectedItem).mokki_id
                    + " AND varaus.varattu_loppupvm > strftime('%s', 'now') AND varaus.varattu_alkupvm > strftime('%s', 'now')");

                    foreach (DataRow i in paivat)
                    {
                        lista.Add(UnixTimeStampToDateTime(Convert.ToDouble(i[0].ToString())));
                    }

                    foreach (DataRow i in paivat2)
                    {
                        lista2.Add(UnixTimeStampToDateTime(Convert.ToDouble(i[0].ToString())));
                        lista3.Add(UnixTimeStampToDateTime(Convert.ToDouble(i[1].ToString())));
                    }

                    if (lista2.Count != 0)
                    {
                        dateTimePicker_Lahto.MaxDate = lista3.Min().Subtract(new TimeSpan(24, 0, 0));
                        dateTimePicker_Tulo.MaxDate = dateTimePicker_Lahto.MaxDate;
                        dateTimePicker_Tulo.MinDate = DateTime.Now;
                        dateTimePicker_Lahto.MinDate = DateTime.Now.AddDays(1);
                        lista2.Clear();
                    }

                    if (lista.Count != 0)
                    {
                        dateTimePicker_Tulo.MinDate = lista.Max().AddDays(1);
                        dateTimePicker_Lahto.MinDate = dateTimePicker_Tulo.MinDate.AddDays(1);
                        lista.Clear();
                    }
                   
                }
                */
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

            foreach (Cabin c in Mokit)
            {
                if (c.toimintaalue_id == ((OperatingArea)combobox_Cabin_Region.SelectedItem).toimintaalue_id)
                {
                    NakyvatMokit.Add(c);
                }
            }

            if (combobox_Cabin_Region.SelectedItem.ToString() == "<kaikki>")
            {
                NakyvatMokit = Mokit;
            }

        }

        private void txt_Cabin_Search_Name_TextChanged(object sender, EventArgs e)
        {
            NakyvatMokit.Clear();
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
                NakyvatMokit.Add(c);
            }
            
        }
        private void clear_txt_boxes()
        {
            txtboxAsiakas_id.Clear();
            txtboxEtunimi.Clear();
            txtboxSukunimi.Clear();
            txtboxPostinro.Clear();
            textBox_PostiToimiPaikka.Clear();
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
            try
            {
                SetConnection();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = textquery;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Tapahtui virhe!");
                //throw;
            }
        }


        private void buttonLisääMuokkaa_Click(object sender, EventArgs e)
        {
            SQL s = new SQL();
            if (dataGridView1.SelectedCells.Count <= 0)
            {
                try
                {
                    string textquery = "INSERT INTO asiakas(asiakas_id,postinro,postitoimipaikka,etunimi,sukunimi,lahiosoite,email,puhelinnro)values('" + txtboxAsiakas_id.Text + "'," +
                    " '" + txtboxPostinro.Text + "' , '" + textBox_PostiToimiPaikka.Text + "' , '" + txtboxEtunimi.Text + "' , '" + txtboxSukunimi.Text + "' , '" + txtboxlahiosoite.Text +
                    "' , '" + @txtboxEmail.Text + "' , '" + txtboxPuhelinnro.Text + "')";
                    ExecuteQuery(textquery);
                    dataGridView1.DataSource = s.returnstuff();
                    MessageBox.Show("Lisäys onnistui");
                }
                catch (Exception)
                {
                    MessageBox.Show("Tapahtui virhe!");
                    //throw;
                }

            }
            else
            {
                try
                {
                    string textquery = "UPDATE asiakas SET postinro = '" + txtboxPostinro.Text + "', postitoimipaikka = '" +textBox_PostiToimiPaikka.Text + "', etunimi = '" + txtboxEtunimi.Text +
                    "', sukunimi ='" + txtboxSukunimi.Text + "', lahiosoite ='" + txtboxlahiosoite.Text + "', email ='" + txtboxEmail.Text +
                    "', puhelinnro ='" + txtboxPuhelinnro.Text + "' WHERE asiakas_id = '" + txtboxAsiakas_id.Text + "';";
                    ExecuteQuery(textquery);
                    dataGridView1.DataSource = s.returnstuff();
                    MessageBox.Show("Muokkaus onnistui");
                }
                catch (Exception)
                {
                    MessageBox.Show("Tapahtui virhe!");
                    //throw;
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
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void Btn_Varaa_Click(object sender, EventArgs e)
        {
            int id;
            if(dataGridView1.SelectedRows.Count != 0)
            {

                string textquery = $"INSERT INTO varaus(asiakas_id,mokki_id,varattu_pvm,vahvistus_pvm,varattu_alkupvm,varattu_loppupvm)values(" +
                $"{txtboxAsiakas_id.Text}, {((Cabin)checklist_Loan_Cabins.SelectedItem).mokki_id}, strftime('%s', 'now'), strftime('%s', 'now'), {ConvertToUnixTime(dateTimePicker_Tulo.Value)}, {ConvertToUnixTime(dateTimePicker_Lahto.Value)})";

                SetConnection();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = textquery;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select last_insert_rowid()";
                cmd.ExecuteNonQuery();
                System.Object temp = cmd.ExecuteScalar();
                id = int.Parse(temp.ToString());

                foreach (Service s in valitutpalvelut)
                {
                    textquery = $"INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm)VALUES(" +
                        $"{id},{s.palvelu_id},{1}";
                }


                valitutpalvelut.Clear();
                foreach (Service s in Clb_Palvelut.CheckedItems)
                {
                    valitutpalvelut.Add(s);
                }



                Lasku lasku = new Lasku(
                    new Client(txtboxEtunimi.Text, txtboxSukunimi.Text, Convert.ToInt32(txtboxAsiakas_id.Text), txtboxlahiosoite.Text, txtboxEmail.Text, txtboxPuhelinnro.Text, txtboxPostinro.Text, textBox_PostiToimiPaikka.Text),
                    ((Cabin)checklist_Loan_Cabins.SelectedItem),
                    new Reservation(id, Convert.ToInt32(txtboxAsiakas_id.Text), ((Cabin)checklist_Loan_Cabins.SelectedItem).mokki_id, Convert.ToInt32(ConvertToUnixTime(DateTime.Now)), Convert.ToInt32(ConvertToUnixTime(DateTime.Now)), Convert.ToInt32(ConvertToUnixTime(dateTimePicker_Tulo.Value)), Convert.ToInt32(ConvertToUnixTime(dateTimePicker_Lahto.Value))),
                    new Invoice(0, id, Convert.ToDouble(txtHinta.Text), 24),
                    valitutpalvelut.ToArray()
                    );
                MessageBox.Show("Lisäys onnistui");
                lasku.Show();

                connection.Close();

            }

           
           
        }

        private void comboBox_HenkMaara_SelectedIndexChanged(object sender, EventArgs e)
        {
            NakyvatMokit.Clear();

            foreach (Cabin c in Mokit)
            {
                if (c.henkilomaara >= int.Parse(comboBox_HenkMaara.Text) && c.varattu == false)
                {
                    NakyvatMokit.Add(c);
                }
            }
        }

        private void textBox_HaeSukunimella_TextChanged(object sender, EventArgs e)
        {
            SetConnection();
            connection.Open();
            adapt = new SQLiteDataAdapter("SELECT * FROM asiakas WHERE sukunimi like '" + textBox_HaeSukunimella.Text + "%'", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void Btn_Tyhjenna_Click(object sender, EventArgs e)
        {
            clear_txt_boxes();
            dataGridView1.ClearSelection();
        }

        private void txtboxAsiakas_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Buttonvaraa()
        {
 
            if (String.IsNullOrWhiteSpace(txtHinta.Text))
            {
                Btn_Varaa.Enabled = false;
            }
            else
            {
                Btn_Varaa.Enabled = true;
            }
        }

        private void txtHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Buttonvaraa();
            if (string.IsNullOrWhiteSpace(txtHinta.Text))
            {
                Btn_Varaa.Enabled = false;
            }
            else
            {
                Btn_Varaa.Enabled = true;
            } 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                
            }
        }

      
    }
}
