using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Utils
{
    internal class Utils
    {
        internal static DataTable ToDataTable<T>(IEnumerable<T> lista, params string[] propiedades)
        {
            DataTable dataTable = new DataTable();

            // Obtener las propiedades de la clase T
            PropertyInfo[] propiedadesClase = typeof(T).GetProperties();

            // Crear las columnas en el DataTable basándonos en las propiedades seleccionadas
            foreach (string nombrePropiedad in propiedades)
            {
                PropertyInfo propiedad = propiedadesClase.FirstOrDefault(p => p.Name == nombrePropiedad);

                if (propiedad != null)
                {
                    dataTable.Columns.Add(nombrePropiedad, propiedad.PropertyType);
                }
                else
                {
                    throw new ArgumentException($"La propiedad {nombrePropiedad} no existe en la clase {typeof(T).Name}");
                }
            }

            // Llenar el DataTable con los datos de la lista
            foreach (T objeto in lista)
            {
                DataRow fila = dataTable.NewRow();

                foreach (string nombrePropiedad in propiedades)
                {
                    PropertyInfo propiedad = propiedadesClase.First(p => p.Name == nombrePropiedad);
                    fila[nombrePropiedad] = propiedad.GetValue(objeto);
                }

                dataTable.Rows.Add(fila);
            }

            return dataTable;
        }
    }
}
