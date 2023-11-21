using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Automovil : Vehiculo
    {
        private TipoAutomovil _tipo;
        private int _cantidadPuertas;

        public TipoAutomovil Tipo { get => _tipo; set => _tipo = value; }
        public int CantidadPuertas { get => _cantidadPuertas; set => _cantidadPuertas = value; }
    }
}
