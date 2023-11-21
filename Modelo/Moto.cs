using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Moto : Vehiculo
    {
        private string _cilindrada;

        public string Cilindrada { get => _cilindrada; set => _cilindrada = value; }
    }
}
