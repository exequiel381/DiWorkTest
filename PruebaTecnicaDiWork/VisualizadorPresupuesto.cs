using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnicaDiWork
{
    public partial class VisualizadorPresupuesto : Form
    {
        private Presupuesto _p;
        public VisualizadorPresupuesto(Presupuesto presupueto)
        {
            _p = presupueto;
            InitializeComponent();
            lblCliente.Text = _p.Cliente.Nombre +" "+ _p.Cliente.Apellido;
            lblVehiculo.Text = _p.Vehiculo.ToString();
            lblManoDeObra.Text = (_p.Total - _p.TotalCostoRepuestos).ToString();
            lblCantidadDias.Text = _p.TotalDias.ToString();
            lblTotalRepuestos.Text = _p.TotalCostoRepuestos.ToString();
            lblTotal.Text = _p.Total.ToString();    
            lblRepuestos.Text = _p.ListaTotalRepuestos;
            lblDesperfecto.Text = _p.ListaDesperfectos;
        }

        private void VisualizadorPresupuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
