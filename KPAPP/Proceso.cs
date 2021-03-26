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

      
        public static string rol;
        public static int idusuario;
        public static int idrol;
        public static bool estado;
        public static string usuario;
        private void formato()
        {
            DgvProceso.Columns[0].Visible = false;
            DgvProceso.Columns[1].Visible = false;
            DgvProceso.Columns[2].Visible = false;
            DgvProceso.Columns[3].Visible = false;
            DgvProceso.Columns[4].HeaderText = "ORDEN DE TAREA";
            DgvProceso.Columns[5].HeaderText = "DESCRIPCION DE TAREA";
            DgvProceso.Columns[6].HeaderText = "USUARIO";
            
            DgvProceso.Columns[7].HeaderText = "CONTROL NIVEL 1";
            DgvProceso.Columns[8].HeaderText = "CONTROL NIVEL 2";
            DgvProceso.Columns[10].HeaderText = "FECHA DE TAREA CERRADA";
            DgvProceso.Columns[11].Visible = false;
            txttask.Text = DgvProceso.RowCount.ToString();
            

           
        }

       
       

       private void remain()
        {

            int rem = 0;
            foreach (DataGridViewRow fila in DgvProceso.Rows)
            {
                string a = null;
              
                
                if (Convert.ToString(fila.Cells[8].Value)!="PENDIENTE")
                {
                    rem = rem + 1;
                    txttaskcomp.Text = Convert.ToString(rem);
                }
                
            }


        }

        

        private void listarproceso()
        {

            DgvProceso.DataSource = NProceso_Fabricacion.ListarProceso(Convert.ToInt32(txtidseleccionado.Text));
        }

        private void Proceso_Load(object sender, EventArgs e)
        {
             listarproceso();
            formato();
            remain();
        }



        private void DgvProceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            FrmControl frm = new FrmControl();
            frm.txtidfab.Text = DgvProceso.CurrentRow.Cells[0].Value.ToString();
            frm.txtfechaorden.Text = DgvProceso.CurrentRow.Cells[1].Value.ToString();
            frm.txtnrofabric.Text = DgvProceso.CurrentRow.Cells[2].Value.ToString();
            frm.txtusuario.Text = DgvProceso.CurrentRow.Cells[6].Value.ToString().Trim();
            //CONTROL DE TAREAS
            frm.txtorden.Text = DgvProceso.CurrentRow.Cells[4].Value.ToString() ;
            frm.txttarea.Text = DgvProceso.CurrentRow.Cells[5].Value.ToString();
            frm.txtobser.Text = DgvProceso.CurrentRow.Cells[9].Value.ToString();
            frm.dtpcontrol.Value = Convert.ToDateTime(DgvProceso.CurrentRow.Cells[10].Value);
            frm.txtidtarea.Text = DgvProceso.CurrentRow.Cells[11].Value.ToString();

            frm.Show();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
             
        }

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

          
        }

        private void DgvProceso_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ((DataGridViewTextBoxEditingControl)sender).CharacterCasing = CharacterCasing.Upper;
        }
    }
}
