using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbies
{
    class ReservationService
    {
        /* "varaus_id INT(11)  NOT NULL," +
              "palvelu_id INT(11)  NOT NULL," +
              "lkm INT(11) NOT NULL," +
              */
            public int varaus_id { get; set; }
            public int palvelu_id { get; set; }
            public int lkm { get; set; }

        public ReservationService(int varaus_id, int palvelu_id, int lkm)
        {
            this.varaus_id = varaus_id;
            this.palvelu_id = palvelu_id;
            this.lkm = lkm;
        }
    }
}
