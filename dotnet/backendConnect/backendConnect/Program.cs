using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace backendConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ravi;Integrated Security=True");
            SqlDataReader rdr = null;
            try
            {
                con.Open();

                Console.WriteLine("Connection Open");
                SqlCommand cmd = new SqlCommand("select employee_name from employee", con);

                rdr = cmd.ExecuteReader();

                // print the name of each record
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
                con.Close();
            }
            catch
            {

                Console.WriteLine("Connection Cant open");


            }
           
            Console.ReadKey();
        }
    }
}
