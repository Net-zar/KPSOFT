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
    public partial class FrmEditarTarea : Form
    {
        public FrmEditarTarea()
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                DialogResult resultado = MessageBox.Show("Editar Tarea: " + txtnombre.Text + " - Orden: "+ txtorden.Text + ", para el proceso de fabricación: " + txtfabric.Text + " ?"
                    , "Editar Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ; ;
                if (resultado == DialogResult.Yes)
                {
                    rpta = NTarea.Editar(Convert.ToInt32(txtidtarea.Text),Convert.ToInt32(txtorden.Text),txtnombre.Text,txtobservacion.Text);
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Nueva tarea cargada");
                    
                    this.Close();
                    
                }
                else
                {
                    this.MensajeError(rpta);
                }


            }
            catch
            {

            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                DialogResult resultado = MessageBox.Show("Eliminar tarea: " + txtnombre.Text + " - Orden: " + txtorden.Text + ", para el proceso de fabricación: " + txtfabric.Text + "  ?"
                    , "Borrar Tarea - Los cambios no podrán deshacerse", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ; ;
                if (resultado == DialogResult.Yes)
                {
                    rpta = NTarea.BorrarTarea(Convert.ToInt32(txtidtarea.Text));
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se ha eliminado la tarea");

                    this.Close();

                }
                else
                {
                    this.MensajeError("La tarea se encuentra asociada a una Orden en proceso de fabricación abierto. Solo podrá eliminarla desde dicha Orden");
                }


            }
            catch
            {

            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
