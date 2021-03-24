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
    public partial class FrmUsuario : Form
    {
        private string UsuarioAnterior;
        public FrmUsuario()
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
        private void Formato()
        {
            DgvUsuario.Columns[0].Visible = false;
            DgvUsuario.Columns[1].Visible = false;
            DgvUsuario.Columns[2].Visible = false;
        }

        private void Limpiar()
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
        }
        private void Listar()
        {
            DgvUsuario.DataSource = NUsuario.Listar();
        }

        private void Buscar()
        {
            DgvUsuario.DataSource = NUsuario.Buscar(TxtBuscar.Text);
        }

        private void CargaRol()
        {
            try
            {
                cmbrol.DataSource = NRol.Listar();
                cmbrol.DisplayMember = "rol_descrip";
                cmbrol.ValueMember = "idrol";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Listar();
            CargaRol();
            Formato();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (cmbrol.Text == string.Empty || txtusuario.Text == string.Empty || txtcontraseña.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos faltantes");
                    errorIcono.SetError(cmbrol, "Seleccione un rol");
                    errorIcono.SetError(txtusuario, "Ingrese un nombre");
                    errorIcono.SetError(txtcontraseña, "Ingrese una contraseña");
                }
                else
                {
                    rpta = NUsuario.Insertar(Convert.ToInt32(cmbrol.SelectedValue), txtusuario.Text.Trim(), txtcontraseña.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ha creado el usuario correctamente");
                        this.Listar();
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

        private void DgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnEditar.Visible = true;
                button1.Enabled = false;
                txtid.Text = Convert.ToString(DgvUsuario.CurrentRow.Cells["ID"].Value);
                cmbrol.SelectedValue = Convert.ToString(DgvUsuario.CurrentRow.Cells["ROL_ID"].Value);
                this.UsuarioAnterior= DgvUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                txtusuario.Text = DgvUsuario.CurrentRow.Cells["Usuario"].Value.ToString() ;
                TabGral.SelectedIndex = 1;


            }catch(Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "|Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtid.Text==string.Empty || cmbrol.Text == string.Empty || txtusuario.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos faltantes");
                    errorIcono.SetError(cmbrol, "Seleccione un rol");
                    errorIcono.SetError(txtusuario, "Ingrese un nombre");
                    errorIcono.SetError(txtcontraseña, "Ingrese una contraseña");
                }
                else
                {
                    rpta = NUsuario.Actualizar(Convert.ToInt32(txtid.Text), Convert.ToInt32(cmbrol.SelectedValue),this.UsuarioAnterior ,txtusuario.Text.Trim(), txtcontraseña.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó correctamente");
                        this.Listar();
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGral.SelectedIndex = 0;
        }
    }
}