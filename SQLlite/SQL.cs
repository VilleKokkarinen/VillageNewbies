using FastMember;
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

        public DataTable SqliteQuery_DT(string command)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                connection.Open();
                using (SQLiteCommand fmd = connection.CreateCommand())
                {
                    fmd.CommandText = @command;
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataAdapter sqlda = new SQLiteDataAdapter(fmd.CommandText, connection);

                    DataTable dt;

                    using (dt = new DataTable())
                    {
                        sqlda.Fill(dt);
                    }
                    return dt;
                }
            }
        }
        public List<DataRow> SQLiteQuery_DataRowList(string command)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                connection.Open();
                using (SQLiteCommand fmd = connection.CreateCommand())
                {
                    fmd.CommandText = @command;
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataAdapter sqlda = new SQLiteDataAdapter(fmd.CommandText, connection);

                    DataTable dt;

                    using (dt = new DataTable())
                    {
                        sqlda.Fill(dt);
                    }
                    return dt.AsEnumerable().ToList();
                }
            }
        }
        public string SQLiteQuery_single(string command)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                connection.Open();
                using (SQLiteCommand fmd = connection.CreateCommand())
                {
                    fmd.CommandText = @command;
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        return r[0].ToString();
                    }
                    return null;
                }
            }
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

        /// <summary>
        /// Palauttaa KAIKKI mökit, myös jo varatut
        /// </summary>
        /// <returns></returns>
        public static List<Cabin> GetAllCabins()
        {
            List<Cabin> ImportedFiles = new List<Cabin>();

            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                using (SQLiteCommand availableItems = connection.CreateCommand())
                {
                    connection.Open();

                    availableItems.CommandText = @"SELECT * FROM mokki";
                    availableItems.CommandType = CommandType.Text;
                    SQLiteDataReader r = availableItems.ExecuteReader();
                    while (r.Read())
                    {
                    ImportedFiles.Add(
                        new Cabin(
                            Convert.ToInt32(r[0].ToString()), // <-> i["mokki_id"]
                            Convert.ToInt32(r[1].ToString()),
                            r[2].ToString(),
                            r[3].ToString(),
                            r[4].ToString(),
                            r[5].ToString(),
                            Convert.ToInt32(r[6].ToString()),
                            r[8].ToString(),
                            Convert.ToInt32(r[7].ToString())));
                    }
                }
                connection.Close();
            }
            return ImportedFiles;
        }

        public static List<Service> GetAllServices()
        {
            List<Service> ImportedFiles = new List<Service>();

            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                using (SQLiteCommand availableItems = connection.CreateCommand())
                {
                    connection.Open();

                    availableItems.CommandText = @"SELECT * FROM palvelu";
                    availableItems.CommandType = CommandType.Text;
                    SQLiteDataReader r = availableItems.ExecuteReader();
                    while (r.Read())
                    {
                        ImportedFiles.Add(
                            new Service(
                                palvelu_id: Convert.ToInt32(r["palvelu_id"].ToString()),
                                toimintaalue_id: Convert.ToInt32(r["toimintaalue_id"].ToString()),
                                nimi: r["nimi"].ToString(),
                                kuvaus: r["kuvaus"].ToString(),
                                hinta: Convert.ToInt32(r["hinta"].ToString()),
                                ALV: Convert.ToInt32(r["alv"].ToString())
                                ));

                    }
                }
                connection.Close();
            }
            return ImportedFiles;
        }

        public static List<OperatingArea> GetAllAreas()
        {
            List<OperatingArea> ImportedFiles = new List<OperatingArea>();

            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                using (SQLiteCommand availableItems = connection.CreateCommand())
                {
                    connection.Open();

                    availableItems.CommandText = @"SELECT * FROM toimintaalue";
                    availableItems.CommandType = CommandType.Text;
                    SQLiteDataReader r = availableItems.ExecuteReader();
                    while (r.Read())
                    {
                        ImportedFiles.Add(
                            new OperatingArea(
                                toimintaalue_id: Convert.ToInt32(r["toimintaalue_id"].ToString()),
                                nimi: r["nimi"].ToString()
                                ));

                    }
                }
                connection.Close();
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

        public DataTable returnCabinsDT()
        {
            using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {

                    string CommandText = "SELECT * FROM mokki";
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

        public DataTable returnServicesDT()
        {
            using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {

                    string CommandText = "SELECT * FROM palvelu";
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

        public DataTable returnReservationsDT()
        {
            using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {

                    string CommandText = "SELECT * FROM varaus";
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

        public DataTable returnAreasDT()
        {
            using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=VillageNewbiesDB.db"))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {

                    string CommandText = "SELECT * FROM toimintaalue";
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

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS posti (" +
                "postinro CHAR(5) NOT NULL," +
                "toimipaikka VARCHAR(45) NULL," +
                "PRIMARY KEY(postinro))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO posti(postinro,toimipaikka)" + "VALUES('70100','Kuopio')," + 
                "('00100','Helsinki')," + 
                "('90100','Oulu')," +
                "('20100','Turku')";
            cmd.ExecuteNonQuery();

          

            cmd.CommandText = "DROP TABLE IF EXISTS asiakas";
            cmd.ExecuteNonQuery();



        cmd.CommandText = "CREATE TABLE IF NOT EXISTS asiakas (" +
          "asiakas_id INTEGER PRIMARY KEY AUTOINCREMENT," +
          "postinro CHAR(5) NOT NULL," +
          "postitoimipaikka VARCHAR(20) NULL DEFAULT NULL," +
          "etunimi VARCHAR(20) NULL DEFAULT NULL," +
          "sukunimi VARCHAR(40) NULL DEFAULT NULL," +
          "lahiosoite VARCHAR(40) NULL DEFAULT NULL," +
          "email VARCHAR(50) NULL DEFAULT NULL," +
          "puhelinnro VARCHAR(15) NULL DEFAULT NULL," +
          "FOREIGN KEY(postinro) REFERENCES posti(postinro))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO asiakas(asiakas_id,postinro,postitoimipaikka,etunimi,sukunimi,lahiosoite,email,puhelinnro)" +
                "VALUES('100','70100','Kuopio','Matti','Meikäläinen','Kuopiontie1','matti.m@gmail.com','0505005005')," +
                "('101','70100','Kuopio', 'Keijo', 'Kuosmanen', 'Petosentie5', 'keijo.k@gmail.com', '0506665005')," +
                "('102','70100','Kuopio', 'Sirpa', 'Suokas', 'Vuorikatu11', 'sirpa.s@gmail.com', '0446074567')," +
                "('103','00100','Helsinki', 'Aaro', 'Oksman', 'MannerKatu3', 'aaro.o@gmail.com', '0409874322')," +
                "('104','00100','Helsinki', 'Ben', 'För', 'Restikuja13', 'ben.f@gmail.com', '0502265105')," +
                "('105','00100','Helsinki', 'Leena', 'Kuokas', 'Omatie9', 'leena.k@gmail.com', '0442346789')," +
                "('106','90100','Oulu', 'Oili', 'Vanukas', 'Ouluntie83', 'oili.v@gmail.com', '0405285344')," + 
                "('107','90100','Oulu', 'Kalle', 'Kehveli', 'Rööperitie23', 'kalle.k@gmail.com', '0509263456')," + 
                "('108','20100','Turku', 'Seppo', 'Turunen', 'Turuntie8', 'seppo.t@gmail.com', '0501234567')," +
                "('109','20100','Turku', 'Pentti', 'Hirvonen', 'Hirvoskuja13', 'pentti.h@gmail.com', '0445542689')";
            cmd.ExecuteNonQuery();



            string[] _firstName = new string[] { "Adam", "Alex", "Aaron", "Ben", "Carl", "Dan", "David", "Edward", "Fred", "Frank", "George", "Hal", "Hank", "Ike", "John", "Jack", "Joe", "Larry", "Monte", "Matthew", "Mark", "Nathan", "Otto", "Paul", "Peter", "Roger", "Roger", "Steve", "Thomas", "Tim", "Ty", "Victor", "Walter" };

            string[] _lastName = new string[] { "Anderson", "Ashwoon", "Aikin", "Bateman", "Bongard", "Bowers", "Boyd", "Cannon", "Cast", "Deitz", "Dewalt", "Ebner", "Frick", "Hancock", "Haworth", "Hesch", "Hoffman", "Kassing", "Knutson", "Lawless", "Lawicki", "Mccord", "McCormack", "Miller", "Myers", "Nugent", "Ortiz", "Orwig", "Ory", "Paiser", "Pak", "Pettigrew", "Quinn", "Quizoz", "Ramachandran", "Resnick", "Sagar", "Schickowski", "Schiebel", "Sellon", "Severson", "Shaffer", "Solberg", "Soloman", "Sonderling", "Soukup", "Soulis", "Stahl", "Sweeney", "Tandy", "Trebil", "Trusela", "Trussel", "Turco", "Uddin", "Uflan", "Ulrich", "Upson", "Vader", "Vail", "Valente", "Van Zandt", "Vanderpoel", "Ventotla", "Vogal", "Wagle", "Wagner", "Wakefield", "Weinstein", "Weiss", "Woo", "Yang", "Yates", "Yocum", "Zeaser", "Zeller", "Ziegler", "Bauer", "Baxster", "Casal", "Cataldi", "Caswell", "Celedon", "Chambers", "Chapman", "Christensen", "Darnell", "Davidson", "Davis", "DeLorenzo", "Dinkins", "Doran", "Dugelman", "Dugan", "Duffman", "Eastman", "Ferro", "Ferry", "Fletcher", "Fietzer", "Hylan", "Hydinger", "Illingsworth", "Ingram", "Irwin", "Jagtap", "Jenson", "Johnson", "Johnsen", "Jones", "Jurgenson", "Kalleg", "Kaskel", "Keller", "Leisinger", "LePage", "Lewis", "Linde", "Lulloff", "Maki", "Martin", "McGinnis", "Mills", "Moody", "Moore", "Napier", "Nelson", "Norquist", "Nuttle", "Olson", "Ostrander", "Reamer", "Reardon", "Reyes", "Rice", "Ripka", "Roberts", "Rogers", "Root", "Sandstrom", "Sawyer", "Schlicht", "Schmitt", "Schwager", "Schutz", "Schuster", "Tapia", "Thompson", "Tiernan", "Tisler" };

            string[] _kaupungit = new string[] {"Helsinki","Turku", "Kuopio", "Oulu", "Rovaniemi", "Jyväskylä" };

            string monta = "INSERT into asiakas(postinro,postitoimipaikka,etunimi,sukunimi,lahiosoite,email,puhelinnro)VALUES";
            Random r = new Random();
            for (int i = 0; i <= 1000; i++)
            {
                string firstname = _firstName[r.Next(_firstName.Length - 1)];
                string lastname = _lastName[r.Next(_lastName.Length - 1)];

                monta += $"('{r.Next(10000,99999)}', '{_kaupungit[r.Next(5)]}', '{firstname}','{lastname}', '{"tie" + r.Next(5000).ToString()}', '{firstname + "." + lastname + "@gmail.com"}', '{"044"+r.Next(1000000,9999999)}'),";
                System.Threading.Thread.Sleep(10);
            }
            monta = monta.Substring(0, monta.Length - 1);

            cmd.CommandText = monta;
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS toimintaalue";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS toimintaalue (" +
          "toimintaalue_id INTEGER PRIMARY KEY," +
          "nimi VARCHAR(40) NULL DEFAULT NULL)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO toimintaalue(toimintaalue_id,nimi) VALUES('1','Tahko')," + 
                "('2','Levi')," + "('3','Ruka')," + "('4','Himos')";
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
              "hinta DOUBLE(8, 2) NOT NULL,"+
              "varustelu VARCHAR(100) NULL," +
                "FOREIGN KEY(toimintaalue_id) " +
                "REFERENCES toimintaalue(toimintaalue_id) " +
                "FOREIGN KEY(postinro)" +
                "REFERENCES posti(postinro))";
            cmd.ExecuteNonQuery();
            

            cmd.CommandText = "INSERT INTO mokki(mokki_id,toimintaalue_id, hinta, postinro, mokkinimi,katuosoite,kuvaus,henkilomaara,varustelu)" +
                "VALUES" +
                "('200', '1', '50', '87760', 'Tahkola','Tahkontie 1','Perus mökki perheelle','5','2 makuuhuonetta ja 1 kylpyhuone saunalla')," +
                "('201', '1', '60','87060', 'Tohkola', 'Tohkotie 2', 'Laskettelijan mökki', '3', '1 isompi huone kylpyhuoneella ja saunalla')," +
                "('203', '2', '100','87160', 'Levilä', 'Levintie 3', 'Luksus mökki seurueelle', '8', '3 makuuhuonetta, 2 kylpyhuonetta, sauna ja parveke')," +
                "('204', '2', '50','87260', 'Lekkilä', 'Lekikuja 4', 'Laskettelijan mökki', '3', '1 isompi huone kylpyhuoneella ja saunalla')," +
                "('205', '3', '80','87360', 'Rukola', 'Rukantie 5', 'Hieno mökki perheelle', '6', '2 makuuhuonetta ja 1 kylpyhuone saunalla ja ulko paljulla')," +
                "('206', '3', '60','87460', 'Rakola', 'Rakolatie 6', 'Laskettelijan mökki', '3', '1 isompi huone kylpyhuoneella ja saunalla')," +
                "('207', '4', '50','87560', 'Tahkola', 'Tahkontie 1', 'Perus mökki perheelle', '5', '2 makuuhuonetta ja 1 kylpyhuone saunalla')," +
                "('208', '4', '60','87660', 'Himola', 'Himolankuja 8', 'Laskettelijan mökki', '3', '1 isompi huone kylpyhuoneella ja saunalla')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS varaus";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS varaus (" +
              "varaus_id INTEGER PRIMARY KEY AUTOINCREMENT," +
              "asiakas_id INT(11)  NOT NULL," +
              "mokki_id INT NOT NULL," +
              "varattu_pvm INTEGER NULL DEFAULT NULL," +
              "vahvistus_pvm INTEGER NULL DEFAULT NULL," +
              "varattu_alkupvm INTEGER NULL DEFAULT NULL," +
              "varattu_loppupvm INTEGER NULL DEFAULT NULL," +
                "FOREIGN KEY(asiakas_id)" +
                "REFERENCES asiakas (asiakas_id)" +
                "FOREIGN KEY(mokki_id)" +
                "REFERENCES mokki (mokki_id))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO varaus(varaus_id,asiakas_id,mokki_id,varattu_pvm,vahvistus_pvm,varattu_alkupvm,varattu_loppupvm)" +
                "VALUES(300,100,200,1586088000,1586088000,1589112000,1589976000)," +
                "(301,107,205,1586088000,1586088000,1589112000,1589976000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS lasku";
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
               " VALUES(300, 450, 24)," + 
               "(301,550,24)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS palvelu";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS palvelu (" +
              "palvelu_id INTEGER PRIMARY KEY AUTOINCREMENT," +
              "toimintaalue_id INT(11)  NOT NULL," +
              "nimi VARCHAR(40) NULL DEFAULT NULL," +
              "kuvaus VARCHAR(255) NULL DEFAULT NULL," +
              "hinta DOUBLE(8, 2) NOT NULL," +
               "alv DOUBLE(8, 2) NOT NULL," +
                "FOREIGN KEY(toimintaalue_id)" +
                "REFERENCES toimintaalue (toimintaalue_id))";
            cmd.ExecuteNonQuery();


            cmd.CommandText = "INSERT INTO palvelu(palvelu_id, toimintaalue_id, nimi, kuvaus, hinta, alv)" +
               " VALUES(400, 1,'Hevosajelu','2 hevosen rekiajelu', 150, 14)," + 
               "(401, 1,'Laskettelu','1 päivän rinne lippu', 80, 10)," +
               "(403, 2,'Laskettelu','1 päivän rinne lippu', 90, 10)," +
               "(404, 2,'Ravintola passi','Viikonlopun ilmaiset ravintolapalvelut', 100, 24)," +
               "(405, 3,'Laskettelu','1 päivän rinne lippu', 100, 10)," +
               "(406, 3,'Joulupukki','Joulupukki lapsille illaksi', 50, 20)," +
               "(407, 4,'Laskettelu','1 päivän rinne lippu', 80, 10)," +
               "(408, 4,'Moottorikelkkailu','Opastettu moottorikelkkailu ajelu', 40, 14)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DROP TABLE IF EXISTS varauksen_palvelut";
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
               " VALUES(300, 400, 3)," + 
               "(300, 401, 3)," + 
               "(301, 405, 5)," + 
               "(301, 406, 1)";
            cmd.ExecuteNonQuery();       
        }
    }
}
