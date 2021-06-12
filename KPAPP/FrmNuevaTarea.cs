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
            dgvnueva.DataSource = NTarea.Listar();
        }

        private void ListarNueva()
        {
            if (rbmanual.Checked == true)
            {
                dgvnueva.DataSource = NTarea.Buscar(Convert.ToInt32(cmbfabric.SelectedValue));
             


            } else
            {
                if (rbCopiar.Checked == true)
                {
                    dgvnueva.DataSource = NTarea.Buscar(Convert.ToInt32(cmbnuevafab.SelectedValue));
                    lbltareas.Text = cmbnuevafab.Text;

                }
            }
        }

        private void cmb_fabricacion()
        {
          
            cmbfabric.DisplayMember = "fabricacion_nombre";
            cmbfabric.ValueMember = "idfabricacion";
            cmbfabric.DataSource = NTarea.Cmb_Fabricacion();

        }

        private void formato()
        {
            dgvtarea.Columns[0].Visible = false;
            dgvnueva.Columns[0].Visible = false;
        }
        private void formato2()
        {
           
        }
        private void cmb_busca()
        {
           
            cmbbuscar.DisplayMember = "fabricacion_nombre";
            cmbbuscar.ValueMember = "idfabricacion";
            cmbbuscar.DataSource = NTarea.Cmb_Fabricacion();
            cmbbuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void cmb_nuevafab()
        {

            cmbnuevafab.DisplayMember = "fabricacion_nombre";
            cmbnuevafab.ValueMember = "idfabricacion";
            cmbnuevafab.DataSource = NTarea.Cmb_Fabricacion();
            cmbnuevafab.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbnuevafab.BackColor = Color.LightCyan;
        }

        private void Buscar()
        {
        
            dgvtarea.DataSource = NTarea.Buscar(Convert.ToInt32(cmbbuscar.SelectedValue));
        }

        private void BuscarNueva()
        {

            dgvnueva.DataSource = NTarea.Buscar(Convert.ToInt32(cmbnuevafab.SelectedValue));
        }

        private void tipoAlta()
        {
            rbmanual.Checked = true;

           
        }
        private void FrmNuevaTarea_Load(object sender, EventArgs e)
        {
            Listar();
            formato();
            cmb_fabricacion();
            cmb_busca();
            cmb_nuevafab();
            tipoAlta();
            ListarNueva();
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
                    
                    //cmbnuevafab.ValueMember = cmbfabric.ValueMember;
                    Listar();
                    ListarNueva();
                  
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

        private void dgvtarea_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string rpta = "";
                if (cmbbuscar.Text == cmbnuevafab.Text)
                {
                    MessageBox.Show("No se puede copiar una tarea dentro del mismo proceso de fabricación", "Error al copiar tarea");
                }
                else
                {

                    DialogResult resultado = MessageBox.Show("Agregar la tarea " + dgvtarea.CurrentRow.Cells[2].Value.ToString() + "para el proceso de fabricación: " + (cmbnuevafab.SelectedText) + " ?"
                    , "Nueva Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ; ;
                    if (resultado == DialogResult.Yes)
                    {
                        rpta = NTarea.InsertarCopia(Convert.ToInt32(dgvtarea.CurrentRow.Cells[1].Value), Convert.ToString(dgvtarea.CurrentRow.Cells[2].Value), Convert.ToString(dgvtarea.CurrentRow.Cells[3].Value),
                         Convert.ToInt32(cmbnuevafab.SelectedValue));
                    }
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Nueva tarea cargada");

                        Listar();
                        BuscarNueva();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }


                }
            }
            catch
            {

            }
        }

        private void gbradio_Enter(object sender, EventArgs e)
        {

        }

        private void rbmanual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmanual.Checked == true)
            {
                gbnuevatarea.Enabled = true;
                gbfilt.Enabled = false;
               // lbltareas.Text = cmbfabric.SelectedValue.ToString();
                ListarNueva();
            }

           
        }

        private void rbCopiar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopiar.Checked == true)
            {
                gbnuevatarea.Enabled = false;
                gbfilt.Enabled = true;
                ListarNueva();
            }
        }

        private void cmbnuevafab_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbltareas.Text = cmbnuevafab.Text;
            BuscarNueva();
        }

        private void cmbfabric_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbltareas.Text = cmbfabric.Text;
            ListarNueva();
        }

        private void dgvnueva_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmEditarTarea frm = new FrmEditarTarea();
            frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FrmEditarTarea_FormClosed);
            frm.txtidtarea.Text = dgvnueva.CurrentRow.Cells[0].Value.ToString();
            frm.txtorden.Text = dgvnueva.CurrentRow.Cells[1].Value.ToString();
            frm.txtnombre.Text = dgvnueva.CurrentRow.Cells[2].Value.ToString();
            frm.txtobservacion.Text = dgvnueva.CurrentRow.Cells[3].Value.ToString();
            frm.txtfabric.Text = dgvnueva.CurrentRow.Cells[4].Value.ToString();

            frm.Show();
        }

        private void dgvnueva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void FrmEditarTarea_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarNueva();
        }
    }
}
