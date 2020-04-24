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
            List<string> dataa = SQL.AvailableCabinsByNameAndType();
            foreach (string i in dataa)
            {
                checklist_Loan_Items.Items.Add(i);
            }
        }


    }
}
