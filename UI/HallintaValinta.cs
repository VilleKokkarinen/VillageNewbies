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
    public partial class HallintaValinta : Form
    {
        public HallintaValinta()
        {
            InitializeComponent();
        }

        private void button_Mokki_Click(object sender, EventArgs e)
        {
            MokinHallinta mokki = new MokinHallinta();
            mokki.Show();
            mokki.TopMost = true;
            Close();
        }

        private void button_Palvelu_Click(object sender, EventArgs e)
        {
            PalveluHallinta palvelu = new PalveluHallinta();
            palvelu.Show();
            palvelu.TopMost = true;
            Close();
        }
    }
}
