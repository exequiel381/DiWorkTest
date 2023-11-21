using Logica;
using Logica.Builder;
using Logica.Interfaces;
using Persistencia.Interfaces;
using Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PruebaTecnicaDiWork
{
    internal static class Program
    {
        public static IUnityContainer container { get; set; } = new UnityContainer();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            container.RegisterType<IRepuestoRepositorio, RepuestoRepositorio>();
            container.RegisterType<IRepuestoLogica, RepuestoLogica>();

            container.RegisterType<IPresupuestoRepositorio, PresupuestoRepositorio>();
            container.RegisterType<IPresupuestoBuilder, PresupuestoBuilder>();
            container.RegisterType<IEstrategiaCalcutoTotalPresupuesto, EstrategiaCalcutoTotalPresupuesto>();
            container.RegisterType<IPresupuestoLogica, PresupuestoLogica>();
            

            var vistaPrincipal = container.Resolve<frmPresupuestador>();

            Application.Run(vistaPrincipal);
        }
    }
}
