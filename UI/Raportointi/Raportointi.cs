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
        private BindingList<Cabin> Mokit;

        private void Btn_mokit_Click(object sender, EventArgs e)
        {
            foreach (Cabin c in Mokit)
            {
                this.chart_mokit.Series["Varauksien lkm"].Points.AddXY(c.mokkinimi, 15);
            }
        }

        private void Raportointi_Load(object sender, EventArgs e)
        {
            Mokit = new BindingList<Cabin>();
            SQL s = new SQL();
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
            }
        }
    }
}
