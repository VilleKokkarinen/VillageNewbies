using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbies
{
    class SQL
    {
        public SQL()
        {

        }

        public static List<string> GetImportedFileList()
        {
            List<string> ImportedFiles = new List<string>();
            using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT etunimi EtuNimi, sukunimi Sukunimi FROM asiakas";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        ImportedFiles.Add(r["etunimi"].ToString() + " " + r["sukunimi"].ToString());
                    }
                }
            }
            return ImportedFiles;
        }

        public DataTable returnstuff()
        {
            using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {

                    string CommandText = "SELECT * FROM asiakas";
                    SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, connect);

                    DataTable dt;

                    using (dt = new DataTable())
                    {
                        sqlda.Fill(dt);
                    }
                    return dt;
                }
            }
        }

            public void create()
        {

            string cs = @"URI=file:VillageNewbiesDB.db";

            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "DROP TABLE IF EXISTS posti";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS posti ( postinro CHAR(5) NOT NULL, toimipaikka VARCHAR(45) NULL,PRIMARY KEY(postinro))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO posti(postinro,toimipaikka) VALUES('70460','kuopio'),('00100', 'Helsinki')";
            cmd.ExecuteNonQuery();

          

            cmd.CommandText = "DROP TABLE IF EXISTS asiakas";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS asiakas (" +
          "asiakas_id INTEGER PRIMARY KEY," +
          "postinro CHAR(5) NOT NULL," +
          "etunimi VARCHAR(20) NULL DEFAULT NULL," +
          "sukunimi VARCHAR(40) NULL DEFAULT NULL," +
          "lahiosoite VARCHAR(40) NULL DEFAULT NULL," +
          "email VARCHAR(50) NULL DEFAULT NULL," +
          "puhelinnro VARCHAR(15) NULL DEFAULT NULL," +
          "FOREIGN KEY(postinro) REFERENCES posti(postinro))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO asiakas(asiakas_id,postinro,etunimi,sukunimi,lahiosoite,email,puhelinnro)" +
                "VALUES('100','70460','matti','meikalainen','kuopiontie1','matti.m@gmail.com','0505005005')," +
                "('101','70460', 'keijo', 'meikalainen', 'kuopiontie1', 'matti.m@gmail.com', '0505005005')";
            



            cmd.ExecuteNonQuery();


            cmd.CommandText = "DROP TABLE IF EXISTS toimintaalue";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS toimintaalue (" +
          "toimintaalue_id INTEGER PRIMARY KEY," +
          "nimi VARCHAR(40) NULL DEFAULT NULL)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO toimintaalue(nimi) VALUES('Savo')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS mokki";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS mokki(" +
              "mokki_id INTEGER PRIMARY KEY," +
              "toimintaalue_id INT(11) NOT NULL," +
              "postinro CHAR(5) NOT NULL," +
              "mokkinimi VARCHAR(45) NULL," +
              "katuosoite VARCHAR(45) NULL," +
              "kuvaus VARCHAR(150) NULL," +
              "henkilomaara INT NULL," +
              "varustelu VARCHAR(100) NULL," +
                "FOREIGN KEY(toimintaalue_id)" +
                "REFERENCES toimintaalue(toimintaalue_id)" +
                "FOREIGN KEY(postinro)" +
                "REFERENCES posti(postinro))";
            cmd.ExecuteNonQuery();
            

            cmd.CommandText = "INSERT INTO mokki(toimintaalue_id,postinro,mokkinimi,katuosoite,kuvaus,henkilomaara,varustelu)" +
                " VALUES(1,'70460','mokki 1', 'mokkitie 1', 'mokin kuvaus', 5, 'mokin varustelu')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS varaus ;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS varaus (" +
              "varaus_id INTEGER PRIMARY KEY AUTOINCREMENT," +
              "asiakas_id INT(11)  NOT NULL," +
              "mokki_mokki_id INT  NOT NULL," +
              "varattu_pvm DATETIME NULL DEFAULT NULL," +
              "vahvistus_pvm DATETIME NULL DEFAULT NULL," +
              "varattu_alkupvm DATETIME NULL DEFAULT NULL," +
              "varattu_loppupvm DATETIME NULL DEFAULT NULL," +
                "FOREIGN KEY(asiakas_id)" +
                "REFERENCES asiakas (asiakas_id)" +
                "FOREIGN KEY(mokki_mokki_id)" +
                "REFERENCES mokki (mokki_id))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO varaus(asiakas_id,mokki_mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm)" +
                " VALUES(1,1, 1586340108, 1586340109, 1586340109, 1586340110)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS lasku ;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS lasku (" +
          "lasku_id INTEGER PRIMARY KEY AUTOINCREMENT," +
          "varaus_id INT(11)  NOT NULL," +
          "summa DOUBLE(8, 2) NOT NULL," +
           "alv DOUBLE(8, 2) NOT NULL," +
            "FOREIGN KEY(varaus_id)" +
            "REFERENCES varaus(varaus_id))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO lasku(varaus_id, summa, alv )" +
               " VALUES(1, 50, 24)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS palvelu ;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS palvelu (" +
              "palvelu_id INTEGER PRIMARY KEY AUTOINCREMENT," +
              "toimintaalue_id INT(11)  NOT NULL," +
              "nimi VARCHAR(40) NULL DEFAULT NULL," +
              "tyyppi INT(11) NULL DEFAULT NULL," +
              "kuvaus VARCHAR(255) NULL DEFAULT NULL," +
              "hinta DOUBLE(8, 2) NOT NULL," +
               "alv DOUBLE(8, 2) NOT NULL," +
                "FOREIGN KEY(toimintaalue_id)" +
                "REFERENCES toimintaalue (toimintaalue_id))";
            cmd.ExecuteNonQuery();


            cmd.CommandText = "INSERT INTO palvelu(toimintaalue_id, nimi, tyyppi, kuvaus, hinta, alv)" +
               " VALUES(1, 'palvelunnimi',1,'palvelun kuvaus', 50, 24)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS varauksen_palvelut ;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS varauksen_palvelut (" +
              "varaus_id INT(11)  NOT NULL," +
              "palvelu_id INT(11)  NOT NULL," +
              "lkm INT(11) NOT NULL," +
              "PRIMARY KEY(palvelu_id, varaus_id)," +
                "FOREIGN KEY(varaus_id)" +
                "REFERENCES varaus (varaus_id)," +
                "FOREIGN KEY(palvelu_id)" +
                "REFERENCES palvelu (palvelu_id))";
            cmd.ExecuteNonQuery();


            cmd.CommandText = "INSERT INTO varauksen_palvelut(varaus_id, palvelu_id, lkm)" +
               " VALUES(1, 1, 1)";
            cmd.ExecuteNonQuery();       
        }
    }
}
