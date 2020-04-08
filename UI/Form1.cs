using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageNewbies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SQL s = new SQL();
            s.create();

            DataTable dt = s.returnstuff();
            dataGridView1.DataSource = dt;
        }
    }
}
