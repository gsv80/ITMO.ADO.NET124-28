using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADO.NET124_28
{
    
    internal class Program
        {
            static void Main(string[] args)
            {
            using (SqlConnection conn = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = NORTHWND; Data Source = MSI\\MSSQLSERVER04"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT [CustomerID],[CompanyName],[ContactName], [Phone] FROM [dbo].[Customers]", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["CustomerID"]);
                        }
                    }
                }
            }
            }
        }
}



