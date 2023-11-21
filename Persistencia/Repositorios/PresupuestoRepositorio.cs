using Modelo;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Utils;

namespace Persistencia.Repositorios
{
    public class PresupuestoRepositorio : Connection,IPresupuestoRepositorio
    {
        public PresupuestoRepositorio()
        {
            
        }
        public void GuardarPresupuesto(Presupuesto presupuesto)
        {
            Connect();
            try
            {

                #region presupuesto
                var commandPresupuesto = new SqlCommand("Usp_Ins_Presupuesto", connection);
                commandPresupuesto.CommandType = CommandType.StoredProcedure;
                commandPresupuesto.Parameters.Add(new SqlParameter("@pNombre", presupuesto.Cliente.Nombre));
                commandPresupuesto.Parameters.Add(new SqlParameter("@pApellido", presupuesto.Cliente.Apellido));
                commandPresupuesto.Parameters.Add(new SqlParameter("@pEmail", presupuesto.Cliente.Email));
                commandPresupuesto.Parameters.Add(new SqlParameter("@pTotal", presupuesto.Total));
                commandPresupuesto.Parameters.Add(new SqlParameter("@pMarca", presupuesto.Vehiculo.Marca));
                commandPresupuesto.Parameters.Add(new SqlParameter("@pModelo", presupuesto.Vehiculo.Modelo));
                commandPresupuesto.Parameters.Add(new SqlParameter("@pPatente", presupuesto.Vehiculo.Patente));

                if (presupuesto.Vehiculo is Automovil auto)
                {
                    commandPresupuesto.Parameters.Add(new SqlParameter("@pEsAuto", 1));
                    commandPresupuesto.Parameters.Add(new SqlParameter("@pTipo", auto.Tipo));
                    commandPresupuesto.Parameters.Add(new SqlParameter("@pCantPuertas", auto.CantidadPuertas));
                }
                if (presupuesto.Vehiculo is Moto moto)
                {
                    commandPresupuesto.Parameters.Add(new SqlParameter("@pEsAuto", 0));
                    commandPresupuesto.Parameters.Add(new SqlParameter("@pCilindrada", moto.Cilindrada));

                }
                //Transformar lista de desperfectos en dataTable con el campo idsRepuestos
                DataTable desperfectos = Utils.Utils.ToDataTable(presupuesto.Desperfectos, "Descripcion", "ManoDeObra","Tiempo", "IdsRepuestos");
                commandPresupuesto.Parameters.Add(new SqlParameter("@pDesperfectos", desperfectos));
                #endregion

                commandPresupuesto.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
