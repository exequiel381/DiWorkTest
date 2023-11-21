using Logica.Interfaces;
using Modelo;
using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Builder
{
    public class PresupuestoBuilder : IPresupuestoBuilder
    {
        private Vehiculo _vehiculo;
        private Presupuesto _presupuesto;
        private Cliente _cliente;
        private IEstrategiaCalcutoTotalPresupuesto _estrategiaCalcutoTotalPresupuesto;

        public PresupuestoBuilder(IEstrategiaCalcutoTotalPresupuesto estrategiaCalcutoTotalPresupuesto)
        {
            _estrategiaCalcutoTotalPresupuesto = estrategiaCalcutoTotalPresupuesto;
        }

        public void ConstruirPresupuesto(List<Desperfecto> desperfectos)
        {
            _presupuesto = new Presupuesto();
            _presupuesto.Cliente = _cliente;
            _presupuesto.Vehiculo = _vehiculo;
            _presupuesto.Desperfectos = desperfectos;
            _presupuesto.Total = _estrategiaCalcutoTotalPresupuesto.CalcularTotal(_presupuesto);
        }

        public void ConstruirVehiculo(bool esAuto, TipoAutomovil tipo, decimal cantPuertas, string cilindrada, string marca, string modelo, string patente)
        {
            if(esAuto) {
                _vehiculo = new Automovil() { Tipo = tipo,CantidadPuertas = (int)cantPuertas, Marca = marca,Modelo = modelo, Patente = patente};
            }
            else
            {
                _vehiculo = new Moto() {Cilindrada = cilindrada, Marca = marca, Modelo = modelo, Patente = patente };
            }
        }

        public void ConstruirCliente(string nombreCliente, string apellidoCliente, string email)
        {
            _cliente = new Cliente() { Nombre = nombreCliente, Apellido = apellidoCliente , Email = email };
        }

        public Presupuesto ObtenerPresupuesto()
        {
            return _presupuesto;
        }
    }
}
