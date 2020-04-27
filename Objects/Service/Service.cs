using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbies
{
    class Service
    {
        /*  "palvelu_id INTEGER PRIMARY KEY AUTOINCREMENT," +
              "toimintaalue_id INT(11)  NOT NULL," +
              "nimi VARCHAR(40) NULL DEFAULT NULL," +
              "kuvaus VARCHAR(255) NULL DEFAULT NULL," +
              "hinta DOUBLE(8, 2) NOT NULL," +
              */

        public int palvelu_id { get; set; }
        public int toimintaalue_id { get; set; }
        public string kuvaus { get; set; }
        public string nimi { get; set; }
        public double hinta { get; set; }
        public double ALV { get; set; }

        public string DISPLAYNAME => $"{nimi} - {kuvaus} - {hinta}";

        public Service(int palvelu_id, int toimintaalue_id, string kuvaus, string nimi, double hinta, double ALV)
        {
            this.palvelu_id = palvelu_id;
            this.toimintaalue_id = toimintaalue_id;
            this.kuvaus = kuvaus;
            this.nimi = nimi;
            this.hinta = hinta;
            this.ALV = ALV;
        }
    }
}
