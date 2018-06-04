using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server=.;database=db_11;uid=sa;pwd=");
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
