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
        private void formato()
        {
            DgvProceso.Columns[0].Visible = false;
            DgvProceso.Columns[1].Visible = false;
            DgvProceso.Columns[2].Visible = false;
            DgvProceso.Columns[3].Visible = false;
            txttask.Text = DgvProceso.RowCount.ToString();
            remain();
        }

        public void Listar_Control_uno()
        {
            CmbControl1.DataSource = NProceso_Fabricacion.Cmb_usuario_uno();
            CmbControl1.DisplayMember = "Usuario_nombre";
            CmbControl1.ValueMember = "idusuario";
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
            Listar_Control_uno();
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
    }
}
