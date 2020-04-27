using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbies.Objects.Cabin
{
    class Services
    {
        public int palvelu_id { get; set; }
        public int toimintaalue_id { get; set; }
        public string nimi { get; set; }
        public string kuvaus { get; set; }
        public double hinta { get; set; }
        public double alv { get; set; }

        public string DISPLAYNAME => $"{nimi} - {kuvaus} - {hinta}";

        public Services()
        {

        }

        public Services(int ID, int ToimintaAlueID, string Nimi, string kuvaus, double hinta, double ALV)
        {
            palvelu_id = ID;
            toimintaalue_id = ToimintaAlueID;
            nimi = Nimi;
            this.kuvaus = kuvaus;
            this.hinta = hinta;
            alv = ALV;
        }
    }
}
