using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp
{
    public class ExceptionDatabase
    {
        //Gestire un’eccezione data dalla mancata connessione a un database filtrando il tipo per errore fatale.
        public static void Run()
        {
            try
            {
                ExceptionSqlQuery();
            }
            catch (SqlException e) when (e.Class > 19)  //dal 19 in poi errore fatale
            {
                Console.WriteLine("Errore fatale");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Errore durante la query.");
            }
        }

        public static void ExceptionSqlQuery()
        {
            SqlConnection conn = new SqlConnection(@" Data Source = .; Database = NonFunziona; Connection timeout = 1");  //Errore classe 20
            conn.Open();
        }
    }
}
