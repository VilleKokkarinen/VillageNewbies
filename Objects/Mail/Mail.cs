using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbies
{
    public class Mail
    {
        /*
         "postinro CHAR(5) NOT NULL," +
         "toimipaikka VARCHAR(45) NULL," +
        */

        public string postinro { get; set; }
        public string toimipaikka { get; set; }

        public string DISPLAYNAME => $"{postinro} - {toimipaikka}";
        public Mail(string postinro, string toimipaikka)
        {
            this.postinro = postinro;
            this.toimipaikka = toimipaikka;
        }
    }
}
