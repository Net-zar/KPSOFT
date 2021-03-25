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

        string comp = "";
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
            txttask.Text = DgvProceso.RowCount.ToString();
            remain();
        }

       

       private void remain()
        {


            int remain = 0;

            if (DgvProceso.Columns[8].ToString() != "NO ASIGNADO")
            {
                remain++;
                txttaskcomp.Text = remain.ToString();
            };


        }



        private void listarproceso()
        {

            DgvProceso.DataSource = NProceso_Fabricacion.ListarProceso(Convert.ToInt32(txtidseleccionado.Text));
        }

        private void Proceso_Load(object sender, EventArgs e)
        {
             listarproceso();
            formato();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txttask_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void chkselec_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void DgvProceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            FrmControl frm = new FrmControl();
            frm.txtorden.Text = DgvProceso.CurrentRow.Cells[4].Value.ToString() ;
            frm.Show();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
             
        }
    }
}
