namespace VillageNewbies
{   
    public class Cabin
    {        
        public int mokki_id { get; set; }
        public int toimintaalue_id { get; set; }
        public string toimintaalue { get; set; }
        public string postinro { get; set; }
        public string mokkinimi { get; set; }
        public string katuosoite { get; set; }
        public string kuvaus { get; set; }
        public int henkilomaara { get; set; }
        public string varustelu { get; set; }
        public double hinta { get; set; }
        public bool varattu { get; set; }

        public string DISPLAYNAME => $"{toimintaalue} - {mokkinimi} - {katuosoite}";


        public Cabin()
        {

        }

        public Cabin(int mokki_id, int toimintaalue_id, string postinro, string mokkinimi, string katuosoite, string kuvaus, int henkilomaara, string varustelu, double hinta)
        {
            this.mokki_id = mokki_id;
            this.toimintaalue_id = toimintaalue_id;
            this.toimintaalue = new SQL().SQLiteQuery_single("SELECT toimintaalue.nimi from toimintaalue where toimintaalue.toimintaalue_id = " + toimintaalue_id);
            this.postinro = postinro;
            this.mokkinimi = mokkinimi;
            this.katuosoite = katuosoite;
            this.kuvaus = kuvaus;
            this.henkilomaara = henkilomaara;
            this.varustelu = varustelu;
            this.hinta = hinta;
            this.varattu = new SQL().SQLiteQuery_single("SELECT CASE WHEN varattu_loppupvm > strftime('%s', 'now') AND varattu_alkupvm < strftime('%s', 'now') THEN 'varattu' ELSE 'avoin' END AS varattu_loppupvm FROM varaus WHERE mokki_id = " + mokki_id) == "varattu" ? true : false;
        }
    }
}
