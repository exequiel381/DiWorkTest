using Modelo;
using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interfaces
{
    public interface IPresupuestoLogica
    {
        Presupuesto GenerarPresupuesto(string nombreCliente, string apellidoCliente, string email, bool esAuto, TipoAutomovil tipo, decimal cantPuertas,string cilindrada, List<Desperfecto> desperfectos,string marca,string modelo,string patente);
    }
}
