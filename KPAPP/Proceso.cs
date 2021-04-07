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
    public partial class Proceso : Form
    {
        public Proceso()
        {
            InitializeComponent();
        }

        // Metodos para mostrar Mensajes 
        private void MensajeError(string mensaje)

        {
            MessageBox.Show(mensaje, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Proceso de carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //-------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------//


        public static string rol;
        public static int idusuario;
        public static int idrol;
        public static bool estado;
        public static string usuario;

        // FRONT END De los datos a mostrar 
        private void formato()
        {
            //Formato de Encabezado de la orden
            dtpfechaorden.Enabled = false;
            txtusrorden.Enabled = false;
            txtnrofabricacion.Enabled = false;
            txttask.Enabled = false;
            txttaskcomp.Enabled = false;

            //Formato DGV
            DgvProceso.Columns[0].Visible = false;
            DgvProceso.Columns[1].Visible = false;
            DgvProceso.Columns[2].Visible = false;
            DgvProceso.Columns[3].Visible = false;
            DgvProceso.Columns[4].HeaderText = "ORDEN DE TAREA";
            DgvProceso.Columns[5].HeaderText = "DESCRIPCION DE TAREA";
            DgvProceso.Columns[6].HeaderText = "USUARIO";
            DgvProceso.Columns[7].HeaderText = "CONTROL NIVEL 1";
            DgvProceso.Columns[8].HeaderText = "CONTROL NIVEL 2";
            DgvProceso.Columns[10].HeaderText = "INICIO DE TAREA";
            DgvProceso.Columns[10].DefaultCellStyle.Format = "dd/MM/yyyy";
            DgvProceso.Columns[11].Visible = false;
            DgvProceso.Columns[12].HeaderText = "CIERRE DE TAREA";
            DgvProceso.Columns[12].DefaultCellStyle.Format = "dd/MM/yyyy";
            DgvProceso.Columns[13].HeaderText = "TIEMPO DE EJECUCIÓN";
            DgvProceso.Columns[14].HeaderText = "CONSUMO DE RESINA (Kg)";
            DgvProceso.Columns[14].DisplayIndex = 11;
            DgvProceso.Columns[15].HeaderText = "CONSUMO DE FIBRA (Kg)";
            DgvProceso.Columns[15].DisplayIndex = 12;
            
            txttask.Text = DgvProceso.RowCount.ToString();


        }


        // Valida si el usuario puede editar una orden cerrada 
        
        private void Muestra_Herramientas()
        {
            if (idrol == 1 || idrol ==3)
            {
                btnherramientas.Enabled = true;
                btnCerrar.Enabled = true;

            }
            else
            {
                btnherramientas.Enabled = false;
                btnCerrar.Enabled = false;
                
            }
        }
        private void Permite_Editar()
        {

            
            if (idrol == 1)
            {

                if (chkcerrada.Checked == true)
                {
                    
                    btnherramientas.Visible = true;
                    btnEditar.Visible = true;
                }
                else
                {
                    
                }
                
            }
        }


        private void Muestra_Estadisticas()
        {
            if(idrol != 1)
            {
                DgvProceso.Columns[13].Visible = false;
            }
        }


        // Recorre el DGV para calcular cuantas tareas estan completadas. 
        private void remain()
        {
            int rem = 0;
            foreach (DataGridViewRow fila in DgvProceso.Rows)
            {

                if (Convert.ToString(fila.Cells[8].Value) != "PENDIENTE")
                {
                    rem = rem + 1;
                    txttaskcomp.Text = Convert.ToString(rem);
                }

            }
        }


        //Recorre el DGV para calcular cuantas tareas restan.
        private void complete()
        {
                int convcom= Convert.ToInt32(txttask.Text);
                int com = convcom;
                foreach (DataGridViewRow fila in DgvProceso.Rows)
                {

                    if (Convert.ToString(fila.Cells[8].Value) != "PENDIENTE")
                    {
                    com = com - 1 ;
                    txtrest.Text = Convert.ToString(com);
                    }

                
            }
        }
        // carga los datos de tareas en el gráfico
        private void estadistica()
        {

            chart.Series["Tareas"].Points.AddXY("Tareas Pendientes", txtrest.Text);
           
            chart.Series["Tareas"].Points.AddXY("Tareas Completadas", txttaskcomp.Text);
        }


        // Lista el proceso de fabricacion 
        private void listarproceso()
        {

            DgvProceso.DataSource = NProceso_Fabricacion.ListarProceso(Convert.ToInt32(txtidseleccionado.Text));


        }
        // En este metodo se cargan todos los metodos a ejecutarse cuando se abre el Form
        private void Proceso_Load(object sender, EventArgs e)
        {
            listarproceso();
            Permite_Editar();
            Muestra_Herramientas();
            formato();
            remain();
            complete();
            estadistica();
            CierraOrden();
            Muestra_Estadisticas();

        }
        // Evalua el estado de la orden. Si esta cerrada, Bloquea el DGV para su edición.
        private void CierraOrden()
        {
            if (chkcerrada.Checked == false)
            {
                chkcerrada.Visible = false;
                btnCerrar.Visible = true;
            }
            else
            {
                btnCerrar.Visible = false;
                chkcerrada.Visible = true;
                DgvProceso.Enabled = false;
            }
        }

        // Toma de la orden seleccionada en el frmOrdenes los campos para mostrar en el encabezado
        private void DgvProceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            FrmControl frm = new FrmControl();
            frm.txtidfab.Text = DgvProceso.CurrentRow.Cells[0].Value.ToString();
            frm.txtfechaorden.Text = DgvProceso.CurrentRow.Cells[1].Value.ToString();
            frm.txtnrofabric.Text = DgvProceso.CurrentRow.Cells[2].Value.ToString();
            frm.txtusuario.Text = DgvProceso.CurrentRow.Cells[6].Value.ToString().Trim();
            //CONTROL DE TAREAS
            frm.txtorden.Text = DgvProceso.CurrentRow.Cells[4].Value.ToString();
            frm.txttarea.Text = DgvProceso.CurrentRow.Cells[5].Value.ToString();
            frm.txtobser.Text = DgvProceso.CurrentRow.Cells[9].Value.ToString();
            frm.txtcantfib.Text = DgvProceso.CurrentRow.Cells[14].Value.ToString();
            frm.txtcantres.Text = DgvProceso.CurrentRow.Cells[15].Value.ToString();
            
            frm.dtpcontrol.Value = Convert.ToDateTime(DgvProceso.CurrentRow.Cells[10].Value);
            if (DgvProceso.CurrentRow.Cells[12].Value != System.DBNull.Value )
            {

                frm.dtpCierre.Value = Convert.ToDateTime(DgvProceso.CurrentRow.Cells[12].Value); 
            }
            else
            {
                frm.dtpCierre.Value = DateTime.Today;
            }

            frm.txtidtarea.Text = DgvProceso.CurrentRow.Cells[11].Value.ToString();

            if (DgvProceso.CurrentRow.Cells[7].Value.ToString() == "PENDIENTE")
            {
                frm.chk1.Enabled = true;
                frm.lblchk1.Visible = false;
                frm.chk2.Enabled = false;
            }
            else
            {

                frm.chk1.Enabled = false;
                frm.lblchk1.Visible = true;
                frm.lblchk1.Text = "CONTROL UNO REALIZADO";

            }
            if (DgvProceso.CurrentRow.Cells[8].Value.ToString() != "PENDIENTE")
            {
                frm.chk2.Enabled = false;
                frm.lblchk2.Visible = true;
                frm.lblchk2.Text = "CONTROL DOS REALIZADO";
                
            }
            else
            {
                frm.chk2.Enabled = true;
            }

            frm.Show();
        }

        //Actualiza el DGV despues de editar alguna fila.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listarproceso();

            chart.Series["Tareas"].Points.Clear();
            estadistica();
            remain();
            complete();



        }
        // Evalua el estado de la tarea para asignarle un color segun su estado
        private void DgvProceso_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvProceso.Columns[e.ColumnIndex].Name == "USUARIO_NOMBRE1")
            {
                if (Convert.ToString(e.Value).StartsWith("PENDIENTE"))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightGreen;

                }
            }
            if (DgvProceso.Columns[e.ColumnIndex].Name == "USUARIO_NOMBRE2")
            {
                if (Convert.ToString(e.Value).StartsWith("PENDIENTE"))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
            }

        }

        private void DgvProceso_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ((DataGridViewTextBoxEditingControl)sender).CharacterCasing = CharacterCasing.Upper;
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DgvProceso.Enabled = true;
        }

        private void btnherramientas_Click(object sender, EventArgs e)
        {
            FrmAgregaHerramientas frm = new FrmAgregaHerramientas();
            frm.txtid.Text = txtidseleccionado.Text;
            frm.txtnroorden.Text = txtnrofabricacion.Text;

            frm.Show();
        }

        private void btnverherramientas_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptListarHerramientas frm = new Reportes.FrmRptListarHerramientas();
            frm.txtidbusqueda.Text = txtidseleccionado.Text;
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            GbCerrar.Visible = true;
            btnverherramientas.Visible = false;
            btnherramientas.Visible = false;
            btnCerrar.Visible = false;
            btnEditar.Visible = false;
            btnActualizar.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                gbautcerrar.Visible = true;
                GbCerrar.Visible = false;
            }
            
        }

        private void btnAceptarchk2_Click(object sender, EventArgs e)
        {
           
        }


        //----------------------- CONTROL PARA CERRAR LA ORDEN --------------------------//
        private void btncierraorden_Click(object sender, EventArgs e)
        {
            try
            {
               
                // Valida si existe el usuario y si tiene los permisos
                string rpta = "";
                DataTable dt = new DataTable();
                dt = NUsuario.Login(txtusuariochkcerrar.Text.Trim(), txtcontraseñachkcerrar.Text.Trim());
                // Verifica si el usuario existe
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario o la clave no existe.", "Validación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    //Verifica si el usuario esta activo 
                    if (Convert.ToBoolean(dt.Rows[0][4]) == false)
                    {
                        MessageBox.Show("Este usuario no está activo", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (checkBox1.Checked == true)
                        {
                            rpta = NNueva_Fabricacion.CerrarOrden(
                                Convert.ToInt32(txtidseleccionado.Text),
                                Convert.ToBoolean(checkBox1.Checked),
                                dtpcierre.Value

                                );

                            if (rpta.Equals("OK"))
                            {
                               DialogResult resultado = MessageBox.Show("La Orden " + txtnrofabricacion.Text + " ha sidor cerrada por el usuario: " + txtusuariochkcerrar.Text, "ORDEN CERRADA",
                                   MessageBoxButtons.OK,MessageBoxIcon.Information);
                                if (resultado == DialogResult.OK)
                                {
                               
                                    this.Close();
                                    
                                }  

                            }
                            else
                            {
                                this.MensajeError(rpta);
                                this.Close();
                            }
                        }

                    }
              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void chartconsumo_Click(object sender, EventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard();
            frm.txtnrofabricacion.Text = txtidseleccionado.Text;
            frm.dtpfechaorden.Value = dtpfechaorden.Value;
            frm.dtpCierre.Value = dtpcierre.Value;
            //if (DgvProceso.CurrentRow.Cells[12].Value != System.DBNull.Value)
            //{

            //    frm.dtpCierre.Value = Convert.ToDateTime(DgvProceso.CurrentRow.Cells[12].Value);
            //}
            //else
            //{
            //    frm.dtpCierre.Value = DateTime.Today;
            //}
            frm.txtidseleccionado.Text = txtidseleccionado.Text;
            frm.txtnroorden.Text = txtnrofabricacion.Text;
            frm.txtusrorden.Text = txtusrorden.Text;
            frm.txtnotas.Text = txtnotas.Text;
            frm.Show();

        }
    }

    }

