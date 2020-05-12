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
    public partial class MokkiRaportointi : Form
    {

        private BindingList<Cabin> Mokit;
        private BindingList<Reservation> MokinVaraukset;
        private int MokinVaratutPaivat;

        public MokkiRaportointi()
        {
            InitializeComponent();

            Mokit = new BindingList<Cabin>();
            List<DataRow> data = new SQL().SQLiteQuery_DataRowList("SELECT * FROM mokki");

            foreach (DataRow i in data)
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
            }
            checklist_Cabins.DataSource = Mokit;
            checklist_Cabins.DisplayMember = "DISPLAYNAME";

          

        }

        private void checklist_Cabins_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checklist_Cabins.CheckedItems.Count > 0)
            {
                checklist_Cabins.ItemCheck -= checklist_Cabins_ItemCheck;
                checklist_Cabins.SetItemChecked(checklist_Cabins.CheckedIndices[0], false);
                checklist_Cabins.ItemCheck += checklist_Cabins_ItemCheck;

            }
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

        private void checklist_Cabins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checklist_Cabins.CheckedIndices.Count == 1)
            {
               MokinVaratutPaivat = 0;
               MokinVaraukset = new BindingList<Reservation>();

                List<DataRow> Varaukset = new SQL().SQLiteQuery_DataRowList("SELECT * FROM varaus WHERE varaus.mokki_id = " + ((Cabin)checklist_Cabins.SelectedItem).mokki_id);


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
                    MokinVaraukset.Add(r);

                    MokinVaratutPaivat += new TimeSpan(UnixTimeStampToDateTime(r.varattu_loppupvm).Ticks - UnixTimeStampToDateTime(r.varattu_alkupvm).Ticks).Days;
                }
                checklist_Cabin_Reservations.DataSource = MokinVaraukset;
                checklist_Cabin_Reservations.DisplayMember = "DISPLAYNAME";

                txtCabinDetails.Clear();
                txtCabinDetails.Text += $"mökillä yhteensä varattuja päiviä: {MokinVaratutPaivat}";
            }

        }

        private void checklist_Cabin_Reservations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checklist_Cabin_Reservations.CheckedItems.Count > 0)
            {
                checklist_Cabin_Reservations.ItemCheck -= checklist_Cabin_Reservations_ItemCheck;
                checklist_Cabin_Reservations.SetItemChecked(checklist_Cabin_Reservations.CheckedIndices[0], false);
                checklist_Cabin_Reservations.ItemCheck += checklist_Cabin_Reservations_ItemCheck;

            }
        }

    }
}
