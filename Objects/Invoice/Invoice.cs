namespace VillageNewbies
{
    class Invoice
    {
        /*
           "lasku_id INTEGER PRIMARY KEY AUTOINCREMENT," +
           "varaus_id INT(11)  NOT NULL," +
           "summa DOUBLE(8, 2) NOT NULL," +
           "alv DOUBLE(8, 2) NOT NULL," +
         */
         public int lasku_id { get; set; }
        public int varaus_id { get; set; }
        public double summa { get; set; }
        public int alv { get; set; }

        public Invoice(int lasku_id, int varaus_id, double summa, int alv)
        {
            this.lasku_id = lasku_id;
            this.varaus_id = varaus_id;
            this.summa = summa;
            this.alv = alv;
        }
    }
}
