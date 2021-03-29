using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocios;

namespace KPAPP
{
    public partial class FrmNuevaTarea : Form
    {
        public FrmNuevaTarea()
        {
            InitializeComponent();
        }
        private void MensajeError(string mensaje)

        {
            MessageBox.Show(mensaje, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Proceso de carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Listar()
        {
            dgvtarea.DataSource = NTarea.Listar();
        }

        private void cmb_fabricacion()
        {
          
            cmbfabric.DisplayMember = "fabricacion_nombre";
            cmbfabric.ValueMember = "idfabricacion";
            cmbfabric.DataSource = NTarea.Cmb_Fabricacion();

        }

        private void cmb_busca()
        {
           
            cmbbuscar.DisplayMember = "fabricacion_nombre";
            cmbbuscar.ValueMember = "idfabricacion";
            cmbbuscar.DataSource = NTarea.Cmb_Fabricacion();
        }

        private void Buscar()
        {
        
            dgvtarea.DataSource = NTarea.Buscar(Convert.ToInt32(cmbbuscar.SelectedValue));
        }
        private void dgvtarea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void FrmNuevaTarea_Load(object sender, EventArgs e)
        {
            Listar();
            cmb_fabricacion();
            cmb_busca();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbnuevatarea.Visible = true;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtdescrip.Text == string.Empty)
                {
                    this.MensajeError("Ingrese la descripción para la Tarea");
                }
                else
                {
                    rpta = NTarea.Insertar(Convert.ToInt32(txtorden.Text.Trim()), txtdescrip.Text.Trim(), txtobs.Text, Convert.ToInt32(cmbfabric.SelectedValue));
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Nueva tarea cargada");
                    gbnuevatarea.Visible = false;
                    Listar();
                }
                else
                {
                    this.MensajeError(rpta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cmbbusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
