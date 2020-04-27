using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbies
{
    class Reservation
    {
        /*    "varaus_id INTEGER PRIMARY KEY AUTOINCREMENT," +
              "asiakas_id INT(11)  NOT NULL," +
              "mokki_id INT  NOT NULL," +
              "varattu_pvm INTEGER NULL DEFAULT NULL," +
              "vahvistus_pvm INTEGER NULL DEFAULT NULL," +
              "varattu_alkupvm INTEGER NULL DEFAULT NULL," +
              "varattu_loppupvm INTEGER NULL DEFAULT NULL," +
         */
        public int varaus_id { get;set; }
        public int asiakas_id { get; set; }
        public int mokki_id { get; set; }
        public int varattu_pvm { get; set; }
        public int vahvistus_pvm { get; set; }
        public int varattu_alkupvm { get; set; }
        public int varattu_loppupvm { get; set; }

        public Reservation(int varaus_id, int asiakas_id, int mokki_id, int varattu_pvm, int vahvistus_pvm, int varattu_alkupvm, int varattu_loppupvm)
        {
            this.varaus_id = varaus_id;
            this.asiakas_id = asiakas_id;
            this.mokki_id = mokki_id;
            this.varattu_pvm = varattu_pvm;
            this.vahvistus_pvm = vahvistus_pvm;
            this.varattu_alkupvm = varattu_alkupvm;
            this.varattu_loppupvm = varattu_loppupvm;
        }
    }
}
