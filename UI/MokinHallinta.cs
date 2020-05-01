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
    public partial class MokinHallinta : Form
    {
        SQL s = new SQL();
        public MokinHallinta()
        {
            InitializeComponent();
        }

        private void MokinHallinta_Load(object sender, EventArgs e)
        {
            dataGrid_Mokit.DataSource = s.returnstuff();
        }
    }
}
