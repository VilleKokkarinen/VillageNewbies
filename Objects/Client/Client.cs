namespace VillageNewbies
{
    public class Client
    {
        public int asiakas_id { get; set; }
        public string etunimi { get; set; }
        public string sukuimi { get; set; }
        public string lahiosoite { get; set; }
        public string email { get; set; }
        public string puhelinnro { get; set; }
        public string postinro { get; set; }

        public string DISPLAYNAME => $"{etunimi} {sukuimi} - {lahiosoite}";

        public Client()
        {
        }

        public Client(string etunimi, string sukuimi, int asiakas_id, string lahiosoite, string email, string puhelinnro, string postinro)
        {
            this.etunimi = etunimi;
            this.sukuimi = sukuimi;
            this.asiakas_id = asiakas_id;
            this.lahiosoite = lahiosoite;
            this.email = email;
            this.puhelinnro = puhelinnro;
            this.postinro = postinro;
        }
    }
}
