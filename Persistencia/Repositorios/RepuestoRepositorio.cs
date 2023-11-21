using Modelo;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorios
{
    public class RepuestoRepositorio : Connection,IRepuestoRepositorio
    {
        public RepuestoRepositorio()
        {
                
        }
        public List<Repuesto> GetAll()
        {
            var repuestos = new List<Repuesto>();
            Connect();
            try
            {
                var command = new SqlCommand("Usp_Sel_Repuestos", connection);
                command.CommandType = CommandType.StoredProcedure;
                var rows = command.ExecuteReader();
                while (rows.Read())
                {
                    repuestos.Add(new Repuesto()
                    {
                        Id = int.Parse(rows[0].ToString()),
                        Nombre = rows[1].ToString(),
                        Precio = decimal.Parse(rows[2].ToString()),    
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Disconnect();
            }
            return repuestos;
        }
    }
}

