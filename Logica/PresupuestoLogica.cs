using Logica.Builder;
using Logica.Interfaces;
using Modelo;
using Modelo.Enums;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PresupuestoLogica : IPresupuestoLogica //Representa a mi director
    {
        private IPresupuestoBuilder _builder;
        private IPresupuestoRepositorio _repositorio;
        public PresupuestoLogica(IPresupuestoBuilder presupuestoBuilder, IPresupuestoRepositorio presupuestoRepositorio)
        {
            _builder = presupuestoBuilder;  
            _repositorio = presupuestoRepositorio;
        }
        public Presupuesto GenerarPresupuesto(string nombreCliente, string apellidoCliente, string email, bool esAuto, TipoAutomovil tipo, decimal cantPuertas, string cilindrada, List<Desperfecto> desperfectos, string marca, string modelo, string patente)
        {
            try
            {
                _builder.ConstruirVehiculo(esAuto, tipo, cantPuertas, cilindrada, marca, modelo, patente);
                _builder.ConstruirCliente(nombreCliente, apellidoCliente, email);
                _builder.ConstruirPresupuesto(desperfectos);
                Presupuesto p = _builder.ObtenerPresupuesto();
                _repositorio.GuardarPresupuesto(p);
                return p;
            }
            catch (Exception ex) {
                throw new Exception("Error al generar presupuesto : " + ex.Message);
            }
            

        }
    }
}
