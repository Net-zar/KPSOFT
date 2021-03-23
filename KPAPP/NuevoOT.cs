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
    public partial class NuevoOT : Form
    {
        public NuevoOT()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            
            DgvOT.DataSource = NNueva_Fabricacion.Listar();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NuevoOT_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
