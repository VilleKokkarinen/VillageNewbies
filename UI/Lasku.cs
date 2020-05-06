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

        public Lasku()
        {
            InitializeComponent();
        }

        private void Lasku_Load(object sender, EventArgs e)
        {
           label5.Text += new SQL().SQLiteQuery_single("SELECT last_insert_rowid()");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
