using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbies
{
    class OperatingArea
    {
        /* 
         "toimintaalue_id INTEGER PRIMARY KEY," +
         "nimi VARCHAR(40) NULL DEFAULT NULL)";
        */
        public int toimintaalue_id { get; set; }
        public string nimi { get; set; }

        public OperatingArea(int toimintaalue_id, string nimi)
        {
            this.toimintaalue_id = toimintaalue_id;
            this.nimi = nimi;
        }
    }
}
