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
    public partial class Raportointi : Form
    {
        public Raportointi()
        {
            InitializeComponent();
        }
        private BindingList<Client> asiakkaat;
        private BindingList<Reservation> AsiakkaanVaraukset;

        private void Raportointi_Load(object sender, EventArgs e)
        {
            asiakkaat = new BindingList<Client>();
            SQL s = new SQL();
            List<DataRow> asiakas = new SQL().SQLiteQuery_DataRowList("SELECT * FROM asiakas");

            foreach (DataRow i in asiakas)
            {
                Client c = new Client(
                   i[3].ToString(),
                   i[4].ToString(),
                   Convert.ToInt32(i[0].ToString()),
                   i[5].ToString(),
                   i[6].ToString(),
                   i[7].ToString(),
                   i[1].ToString(),
                   i[2].ToString()
                   );
                asiakkaat.Add(c);
            }
            CheckListAsiakkaat.DataSource = asiakkaat;
            CheckListAsiakkaat.DisplayMember = "DISPLAYNAME";

        }

        private void CheckListAsiakkaat_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && CheckListAsiakkaat.CheckedItems.Count > 0)
            {
                CheckListAsiakkaat.ItemCheck -= CheckListAsiakkaat_ItemCheck;
                CheckListAsiakkaat.SetItemChecked(CheckListAsiakkaat.CheckedIndices[0], false);
                CheckListAsiakkaat.ItemCheck += CheckListAsiakkaat_ItemCheck;
            }
            if (e.NewValue != e.CurrentValue)
            {
                //MokinVarauksenPalvelut = new BindingList<Service>();
            }
        }

        private void CheckListAsiakkaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsiakkaanVaraukset = new BindingList<Reservation>();
            if (CheckListAsiakkaat.CheckedIndices.Count == 1)
            {
                //MokinVaratutPaivat = 0;


                List<DataRow> Varaukset = new SQL().SQLiteQuery_DataRowList("SELECT * FROM varaus WHERE varaus.asiakas_id = " + ((Client)CheckListAsiakkaat.CheckedItems[0]).asiakas_id);


                foreach (DataRow i in Varaukset)
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
                    AsiakkaanVaraukset.Add(r);

                    //MokinVaratutPaivat += new TimeSpan(UnixTimeStampToDateTime(r.varattu_loppupvm).Ticks - UnixTimeStampToDateTime(r.varattu_alkupvm).Ticks).Days;
                }
                CheckListVaraukset.DataSource = AsiakkaanVaraukset;
                CheckListVaraukset.DisplayMember = "DISPLAYNAME";

                //txtCabinDetails.Clear();
                //txtCabinDetails.Text += $"mökillä yhteensä varattuja päiviä: {MokinVaratutPaivat}";
            }
            else
            {
                CheckListVaraukset.DataSource = null;
                //checklist_Cabin_Reservation_Services.DataSource = null;
            }
        }

    }
}
