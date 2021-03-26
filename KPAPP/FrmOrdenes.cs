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
    public partial class FrmOrdenes : Form
    {
        public FrmOrdenes()
        {
            InitializeComponent();
        }

        public static string rol;
        public static int idusuario;
        public static int idrol;
        public static bool estado;
        public static string usuario;

        


        private void Limpiar()
        {
            txtnroorden.Clear();
            txtobs.Clear();
            errorIcono.Clear();
        }
        private void MensajeError(string mensaje)

        {
            MessageBox.Show(mensaje, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Proceso de carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Listar()
        {
            try
            {
                DgvListado.DataSource = NNueva_Fabricacion.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en datos: " + ex.Message + ex.StackTrace);
            }
        }

        public void Listar2()
        {
            try
            {
                DgvListado2.DataSource = NNueva_Fabricacion.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en datos: " + ex.Message + ex.StackTrace);
            }
        }
        private void ListarFabricacion()
        {

            CmbFabric.DataSource = NNueva_Fabricacion.Cmb_Fabricacion();
            CmbFabric.DisplayMember = "fabricacion_nombre";
            CmbFabric.ValueMember = "idfabricacion";
        }

     
        private void ListarUsuario()
        {
            CmbUsuario.DataSource = NUsuario.Cmb_Usuario();
            CmbUsuario.DisplayMember = "Usuario_Nombre";
            CmbUsuario.ValueMember = "idusuario";
        }


        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].HeaderText = "NÚMERO DE ORDEN";
            DgvListado.Columns[3].HeaderText = "FECHA DE ORDEN";
            DgvListado.Columns[4].HeaderText = "TIPO DE FABRICACIÓN";
            DgvListado.Columns[5].HeaderText = "USUARIO";
            DgvListado.Columns[6].HeaderText = "NOTAS";

        }



        public void Buscar()
        {
            DgvListado.DataSource = NNueva_Fabricacion.Buscar(TxtBuscar.Text);
        }
        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            Listar();
            Formato();
            ListarFabricacion();
            ListarUsuario();

            if (idrol == 2)
            {
                lblasociacion.Enabled = false;
                lblfabricacion.Enabled = false;
                lblfecha.Enabled = false;
                lblnroorden.Enabled = false;
                lblobservacion.Enabled = false;
                txtidgenerado.Enabled = false;
                txtnroorden.Enabled = false;
                txtobs.Enabled = false;
                dtpfecha.Enabled = false;
                CmbFabric.Enabled = false;
                CmbUsuario.Enabled = false;
                BtnCreaOrden.Enabled = false;
            }

           
            btnasociar.Visible = false;
            lblasociacion.Visible = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void CmbFabric_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarFabricacion();
        }

        private void BtnCreaOrden_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                string rpta2 = "";


                if (txtnroorden.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos requeridos.");
                    errorIcono.SetError(txtnroorden, "Ingrese un número de orden");
                }
                else
                {
                    rpta = NNueva_Fabricacion.Insertar(dtpfecha.Value, txtobs.Text, Convert.ToInt32(CmbUsuario.SelectedValue), txtnroorden.Text, Convert.ToInt32(CmbFabric.SelectedValue));
                    rpta2 = NProceso_Fabricacion.Insertar_Proceso();

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("La orden se cargó correctamente");
                        this.Limpiar();
                        this.Listar();
                        btnasociar.Visible = true;
                        BtnCreaOrden.Enabled = false;
                        
                        txtidgenerado.Text = DgvListado.CurrentRow.Cells[1].Value.ToString();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnasociar_Click(object sender, EventArgs e)
        {
            DgvListado2.Visible = true;
            Listar2();
            lblasociacion.Visible = true;
        }

        private void DgvListado2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvListado2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidgenerado.Text = DgvListado2.CurrentRow.Cells[0].Value.ToString();

            if (txtidgenerado.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Se asociarán a la orden " + DgvListado2.CurrentRow.Cells[1].Value.ToString() + " las tareas correspondientes a: " + DgvListado2.CurrentRow.Cells[3].Value.ToString(),
                    "Los cambios no pueden deshacerse", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.OK)
                {
                    NProceso_Fabricacion.Actualizadatosproceso(Convert.ToInt32(CmbUsuario.SelectedValue), dtpfecha.Value, Convert.ToInt32(txtidgenerado.Text));
                    BtnCreaOrden.Enabled = true;
                    btnasociar.Enabled = false;
                    DgvListado2.Visible = false;
                    lblasociacion.Visible = false;

                }
                else
                {
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void DgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Proceso frm = new Proceso();

            frm.txtidseleccionado.Text = (DgvListado.CurrentRow.Cells["idnuevafabricacion"].Value).ToString();
            frm.dtpfechaorden.Value = Convert.ToDateTime((DgvListado.CurrentRow.Cells["fecha_inicio"].Value));
            frm.txtnrofabricacion.Text = DgvListado.CurrentRow.Cells[2].Value.ToString();
            frm.lbltipo.Text = DgvListado.CurrentRow.Cells[4].Value.ToString();
            frm.txtusrorden.Text = DgvListado.CurrentRow.Cells[5].Value.ToString();
            frm.txtnotas.Text = DgvListado.CurrentRow.Cells[6].Value.ToString();
           
            frm.Show();
        }
    }
}