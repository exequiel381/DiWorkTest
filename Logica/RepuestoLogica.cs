using Logica.Interfaces;
using Modelo;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class RepuestoLogica : IRepuestoLogica
    {
        private IRepuestoRepositorio _repuestoRepositorio;

        public RepuestoLogica(IRepuestoRepositorio repuestoRepositorio)
        {
            _repuestoRepositorio = repuestoRepositorio;
        }

        public List<Repuesto> GetAll()
        {
            return _repuestoRepositorio.GetAll();
        }
    }
}
