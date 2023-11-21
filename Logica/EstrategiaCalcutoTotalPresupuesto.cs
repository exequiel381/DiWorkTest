using Logica.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EstrategiaCalcutoTotalPresupuesto : IEstrategiaCalcutoTotalPresupuesto
    {
        public EstrategiaCalcutoTotalPresupuesto()
        {
                
        }
        public decimal CalcularTotal(Presupuesto presupuesto)
        {
            return (presupuesto.TotalCostoRepuestos + presupuesto.TotalCostoManoDeObra + presupuesto.TotalCostoEstacionamiento) * 1.1m;
        }
    }
}
