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
        public Lasku()
        {
            InitializeComponent();
        }

        private void Lasku_Load(object sender, EventArgs e)
        {
            Lbl_LaskuIDText.Text = Varaus.GetLaskuID;
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
            Lbl_LaskuIDText.Text = (reader["data"].ToString());
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
