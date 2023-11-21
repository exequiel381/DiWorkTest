using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Connection
    {
        protected SqlConnection connection;

        protected void Connect()
        {
            try
            {
                connection = new SqlConnection(@"Server=localhost;Database=tallerMecanico;Trusted_Connection=True;");
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        protected void Disconnect()
        {
            try
            {
                connection.Close();
                connection.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
