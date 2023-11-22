using Logica;
using Logica.Interfaces;
using Modelo;
using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnicaDiWork
{
    public partial class frmPresupuestador : Form
    {
        private BindingList<Desperfecto> desperfectos;
        private int _indexSelectedRow = -1;
        private TipoAutomovil _tipoAutomovil;
        private IPresupuestoLogica _presupuestoLogica;
        public frmPresupuestador(IRepuestoLogica repuestoLogica, IPresupuestoLogica presupuestoLogica)
        {
            InitializeComponent();
            _presupuestoLogica = presupuestoLogica;
            desperfectos = new BindingList<Desperfecto>();
            cbxRepuestos.DataSource = repuestoLogica.GetAll();
            cbxTipo.DataSource = Enum.GetValues(typeof(TipoAutomovil));
        }

        public frmPresupuestador()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgRepuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void chkAuto_Click(object sender, EventArgs e)
        {
            chkAuto.Checked = true;
            chkMoto.Checked = false;
            pAuto.Visible = true;
            pMoto.Visible = false;

        }

        private void chkMoto_Click(object sender, EventArgs e)
        {
            chkMoto.Checked = true;
            chkAuto.Checked = false;
            pMoto.Visible = true;
            pAuto.Visible = false;
        }

        private void btnAgregarDesp_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == String.Empty)
            {
                MessageBox.Show("No puede agregar una descipcion vacia");
                return;
            }

            Desperfecto desperfecto = new Desperfecto() { Descripcion = txtDesc.Text, ManoDeObra = nManoDeObra.Value, Tiempo = (int)nTiempo.Value };
            desperfectos.Add(desperfecto);
            dgDesperfectos.DataSource = desperfectos;
        }

        private void dgDesperfectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._indexSelectedRow = e.RowIndex;
            Desperfecto desperfecto = desperfectos[e.RowIndex];
            dgRepuestos.Rows.Clear();
            foreach (var item in desperfecto.Repuestos)
            {
                dgRepuestos.Rows.Add(item.Nombre, item.Precio);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_indexSelectedRow < 0)
            {
                MessageBox.Show("Debe seleccionar un desperfecto haciendo click en la tabla izquierda");
                return;
            }
            Repuesto r = (Repuesto)cbxRepuestos.SelectedItem;
            Desperfecto desperfecto = desperfectos[_indexSelectedRow];
            desperfecto.Repuestos.Add(r);
            dgRepuestos.Rows.Add(r.Nombre, r.Precio);

        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tipoAutomovil = (TipoAutomovil)cbxTipo.SelectedItem;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(txtEmail.Text, emailPattern))
                {
                    MessageBox.Show("Debe ingresar un email valido");
                    return;
                }

                if (desperfectos.Count > 0 && txtApellido.Text != "" && txtMarca.Text != "" && txtModelo.Text != "")
                {
                    Presupuesto p =  _presupuestoLogica.GenerarPresupuesto(txtNom.Text, txtApellido.Text, txtEmail.Text, chkAuto.Checked, _tipoAutomovil, numCantP.Value, nCilindrada.Value.ToString(), desperfectos.ToList(), txtMarca.Text, txtModelo.Text, txtPatente.Text);
                    this.desperfectos.Clear();
                    dgDesperfectos.Rows.Clear();
                    dgRepuestos.Rows.Clear();
                    var VistaVisualizadorPresupuesto = new VisualizadorPresupuesto(p);
                    VistaVisualizadorPresupuesto.ShowDialog();
                    //MessageBox.Show("Presupuesto creado con exito");
                }
                else
                {
                    MessageBox.Show("Asegurese de haber llenado todos los campos y haber ingresado desperfectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
