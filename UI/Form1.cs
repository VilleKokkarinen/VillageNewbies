using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VillageNewbies.UI;

namespace VillageNewbies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SQL s = new SQL();
            //s.create();
        }

        private void Btn_Varaus_Click(object sender, EventArgs e)
        {
            Varaus vr = new Varaus();
            vr.ShowDialog();
        }

        private void Btn_Hallinta_Click(object sender, EventArgs e)
        {
            HallintaValinta valinta = new HallintaValinta();
            valinta.ShowDialog();
        }

        private void Btn_Varaukset_Click(object sender, EventArgs e)
        {
            Varaukset varaukset = new Varaukset();
            varaukset.Show();
            varaukset.TopLevel = true;
        }
    }
}
