using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Repuesto : Base
    {
        private string _nombre;
        private decimal _precio;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public decimal Precio { get => _precio; set => _precio = value; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
