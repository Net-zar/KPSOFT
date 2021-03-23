using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CNegocios;
using System.Data.SqlClient;


namespace KPAPP
{
    public partial class FrmAsociaTask : Form
    {
        public FrmAsociaTask()
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

    
        

     
     
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

