using Modelo;
using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Builder
{
    public interface IPresupuestoBuilder
    {
        void ConstruirVehiculo(bool esAuto, TipoAutomovil tipo, decimal cantPuertas, string cilindrada, string marca, string modelo, string patente);
        void ConstruirPresupuesto(List<Desperfecto> desperfectos);
        void ConstruirCliente(string nombreCliente, string apellidoCliente, string email);
        Presupuesto ObtenerPresupuesto();
    }
}
