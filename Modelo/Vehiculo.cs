using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Vehiculo : Base
    {
        private string _marca;
        private string _modelo;
        private string _patente;

        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Patente { get => _patente; set => _patente = value; }

        public override string ToString()
        {
            return $"Marca : {Marca}. Modelo : {Modelo}. Patente : {Patente}";
        }
    }
}
