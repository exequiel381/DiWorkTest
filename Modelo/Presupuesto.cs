using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Presupuesto
    {
        private Vehiculo _vehiculo;

        private decimal _total;

        private Cliente _cliente;

        private List<Desperfecto> _desperfectos;


        public Presupuesto()
        {
            _desperfectos = new List<Desperfecto>();
        }

        public Vehiculo Vehiculo { get => _vehiculo; set => _vehiculo = value; }

        public decimal Total { get => _total; set => _total = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public List<Desperfecto> Desperfectos { get => _desperfectos; set => _desperfectos = value; }

        public decimal TotalCostoRepuestos
        {
            get
            {
                return Desperfectos.Sum(d => d.TotalRepuestos);
            }

        }

        public decimal TotalCostoManoDeObra
        {
            get
            {
                return Desperfectos.Sum(d => d.ManoDeObra);
            }

        }

        public decimal TotalCostoEstacionamiento
        {
            get
            {
                return Desperfectos.Sum(d => d.Tiempo) * int.Parse(ConfigurationManager.AppSettings["CostoEstacionamientoPorDia"]);
            }

        }

        public int TotalDias
        {
            get
            {
                return Desperfectos.Sum(d => d.Tiempo);
            }
        }

        public string ListaDesperfectos
        {
            get
            {
                string ids = "";
                for (int i = 0; i < Desperfectos.Count; i++)
                {
                    if (i == Desperfectos.Count - 1)
                    {
                        ids += Desperfectos[i].Descripcion;
                    }
                    else
                    {
                        ids += Desperfectos[i].Descripcion + ",";
                    }
                }
                return ids;
            }
        }

        public string ListaTotalRepuestos
        {
            get
            {
                string lista = "";
                int maximoPorLinea = 50;
                for (int i = 0; i < Desperfectos.Count; i++)
                {
                    if(lista.Length >= maximoPorLinea)
                    {
                        lista += "\n";
                        maximoPorLinea += 50;
                    }

                    if (i == Desperfectos.Count - 1)
                    {
                        lista += Desperfectos[i].NombresRepuestos;
                    }
                    else
                    {
                        lista += Desperfectos[i].NombresRepuestos + ", ";
                    }
                }
                return lista;
            }
        }
    }
}
