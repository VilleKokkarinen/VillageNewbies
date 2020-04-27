namespace VillageNewbies
{   
    class Cabin
    {        
        public int mokki_id { get; set; }
        public int toimintaalue_id { get; set; }
        public string postinro { get; set; }
        public string mokkinimi { get; set; }
        public string katuosoite { get; set; }
        public string kuvaus { get; set; }
        public int henkilomaara { get; set; }
        public string varustelu { get; set; }

        public string DISPLAYNAME => $"{mokki_id} - {mokkinimi} - {katuosoite}";


        public Cabin()
        {

        }

        public Cabin(int ID, int ToimintaAlueID, string posti, string Nimi, string katu, string kuvaus, int MaxAsukkaat, string varustelu)
        {
            mokki_id = ID;
            henkilomaara = MaxAsukkaat;
            toimintaalue_id = ToimintaAlueID;
            postinro = posti;
            mokkinimi = Nimi;
            katuosoite = katu;
            this.kuvaus = kuvaus;
            this.varustelu = varustelu;
        }


    }
}
