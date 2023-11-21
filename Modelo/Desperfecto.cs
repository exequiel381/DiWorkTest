using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Desperfecto
    {
        private Presupuesto _presupuesto;
        private string _descripcion;
        private decimal _manoDeObra;
        private int _tiempo;
        private List<Repuesto> _repuestos = new List<Repuesto>();

        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public decimal ManoDeObra { get => _manoDeObra; set => _manoDeObra = value; }
        public int Tiempo { get => _tiempo; set => _tiempo = value; }
        public List<Repuesto> Repuestos { get => _repuestos; set => _repuestos = value; }

        public Presupuesto Presupuesto { get => _presupuesto; set => _presupuesto = value; }

        public decimal TotalRepuestos
        {
            get
            {
                return _repuestos.Sum(r => r.Precio);
            }
        }

        public string IdsRepuestos
        {
            get
            {

                string ids = "";
                for (int i = 0; i < Repuestos.Count; i++)
                {
                    if (i == Repuestos.Count - 1)
                    {
                        ids += Repuestos[i].Id;
                    }
                    else
                    {
                        ids += Repuestos[i].Id + ",";
                    }
                }
                return ids;
            }
        }

        public string NombresRepuestos
        {
            get
            {

                string ids = "";
                for (int i = 0; i < Repuestos.Count; i++)
                {
                    if (i == Repuestos.Count - 1)
                    {
                        ids += Repuestos[i].Nombre;
                    }
                    else
                    {
                        ids += Repuestos[i].Nombre + ",";
                    }
                }
                return ids;
            }
        }



    }
}
