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
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
        private PrintDocument printDocument1 = new PrintDocument();
        public Lasku(Client asiakas, Cabin mokki, Reservation varaus, Invoice lasku, Service[] palvelut = null)
        {

            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            label_AsiakasID.Text += " " + asiakas.asiakas_id.ToString();
            labelAsiakas.Text += " " + asiakas.etunimi + " " + asiakas.sukuimi;
            labelOsoite.Text += " " + asiakas.lahiosoite;
            labelPostinumero.Text += " " + asiakas.postinro.ToString();
            labelPostitmp.Text += " " + asiakas.postitoimipaikka.ToString();

            labelLaskunumero.Text += " " + lasku.lasku_id;
            labelVarausID.Text += " " + varaus.varaus_id;
            labelPaivamaara.Text += " " + DateTime.Now;

            labelAlue.Text += " " + mokki.toimintaalue;
            labelVarausOsoite.Text += " " + mokki.katuosoite;

            labellblTulopaiva.Text += " " + UnixTimeStampToDateTime(varaus.varattu_alkupvm).Date;
            labelLahtopaiva.Text += " " + UnixTimeStampToDateTime(varaus.varattu_loppupvm).Date;

            labelHintaperYo.Text += " "; // <- TODO

            labelLisapalvelut.Text += " " + " "; // <- TODO
            foreach(Service s in palvelut)
            {
                textBox1.Text += s.nimi + Environment.NewLine;
            }

            labelLoppuSumma.Text += " "+lasku.summa;
        }


        private void Lasku_Load(object sender, EventArgs e)
        {
            Lbl_VarausIDText.Text = Varaus.GetVarausID;
            Btn_Laheta.Enabled = false;
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

        private void Btn_Tulosta_Click(object sender, EventArgs e)
        {
            Btn_Laheta.Enabled = true;
            PrintDialog p1 = new PrintDialog();
            p1.AllowSelection = true;
            p1.AllowSomePages = true;

            if (p1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

  

        private void printDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));

            e.Graphics.DrawString(labelPaivamaara.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(550, 30));
            e.Graphics.DrawString("LASKU", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(370, 90));

            e.Graphics.DrawString(label_AsiakasID.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString(labelAsiakas.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString(labelOsoite.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString(labelPostinumero.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString(labelPostitmp.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 240));

            e.Graphics.DrawString("VARAUKSEN TIEDOT", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(380, 300));
            e.Graphics.DrawLine(pen, 20, 340, 845, 340);
            e.Graphics.DrawString("Alue ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 350));
            e.Graphics.DrawString("Osoite", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 350));
            e.Graphics.DrawString("Tulopäivä", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(370, 350));
            e.Graphics.DrawString("Lähtöpäivä", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(530, 350));


            e.Graphics.DrawLine(pen, 20, 370, 845, 370);
            e.Graphics.DrawString(labelAlue.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 390));
            e.Graphics.DrawString(labelOsoite.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 390));
            e.Graphics.DrawString(labellblTulopaiva.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(370, 390));
            e.Graphics.DrawString(labelLahtopaiva.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(530, 390));


            e.Graphics.DrawString("LISÄPALVELUT", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(380, 550));
            e.Graphics.DrawLine(pen, 20, 590, 845, 590);
            e.Graphics.DrawString("Palvelun kuvaus", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 600));
            e.Graphics.DrawString("Hinta ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(530, 600));
            e.Graphics.DrawLine(pen, 20, 620, 845, 620);

            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 640));

            e.Graphics.DrawLine(pen, 200, 680, 540, 680);
            e.Graphics.DrawString("LOPPUSUMMA", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 690));
            e.Graphics.DrawString(label_LoppusummaText.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 690));
            e.Graphics.DrawLine(pen, 200, 710, 500, 710);


        }

        private void Btn_Laheta_Click(object sender, EventArgs e)
        {
            Sahkoposti posti = new Sahkoposti();
            posti.Show();
        }
    }
}
