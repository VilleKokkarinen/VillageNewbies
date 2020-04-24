using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DataTable dt = s.returnstuff();

            dataGrid.DataSource = dt;
        }
    }
}
