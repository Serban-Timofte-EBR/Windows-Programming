using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    public class PacientiRepo
    {
        public List<Pacient> pacientiRepo = new List<Pacient>();

        public PacientiRepo() {
            using(SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\serba\\Desktop\\Windows-Programming\\Probleme_Examen\\Model_4\\Model_4\\bazaDeDate.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT Id, Nume, CodM, Tarif FROM Pacineti", conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        String nume = reader.GetString(1);
                        int codM = reader.GetInt32(2);
                        double tarif = reader.GetDouble(3);
                        Pacient pacient = new Pacient(id, nume, codM, (float)tarif);
                        pacientiRepo.Add(pacient);
                    }
                }
            }
        }
    }
}
