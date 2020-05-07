using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageNewbies.UI
{
    public partial class Lasku : Form
    {
        SQL s = new SQL();
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        public Lasku(Client asiakas, Cabin mokki, Reservation varaus, Invoice lasku)
        {
            InitializeComponent();
            label_AsiakasID.Text += " " +asiakas.asiakas_id.ToString();
            labelAsiakas.Text += " " + asiakas.etunimi + " " + asiakas.sukuimi;
            labelOsoite.Text += " " + asiakas.lahiosoite;
            labelPostinumero.Text += " " + asiakas.postinro.ToString();
            labelPostitmp.Text += " " + asiakas.postinro.ToString(); // POSTITOIMIPAIKKA <- !!!

            labelLaskunumero.Text += " " + lasku.lasku_id;
            labelVarausID.Text += " " + varaus.varaus_id;
            labelPaivamaara.Text += " " + DateTime.Now;

            labelAlue.Text += " " + mokki.toimintaalue;
            labelVarausOsoite.Text += " " + mokki.katuosoite;

            labellblTulopaiva.Text += " " + varaus.varattu_alkupvm;
            labelLahtopaiva.Text += " " + varaus.varattu_loppupvm;

            labelHintaperYo.Text += " "; // <- TODO

            labelLisapalvelut.Text += " " + " "; // <- TODO

            labelLoppuSumma.Text += lasku.summa;
        }

        private void Lasku_Load(object sender, EventArgs e)
        {
            Lbl_VarausIDText.Text = Varaus.GetVarausID;
            //FillForm();
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
            //connection.Close();

        }

        private void FillForm()
        {
            string textquery = "SELECT last_insert_rowid()";
            ExecuteQuery(textquery);
            SQLiteDataReader reader = cmd.ExecuteReader();
            Lbl_VarausIDText.Text = (reader["data"].ToString());
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
