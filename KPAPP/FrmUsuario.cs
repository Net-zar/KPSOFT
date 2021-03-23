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
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void Formato()
        {
            DgvUsuario.Columns[0].Visible = false;
            DgvUsuario.Columns[1].Visible = false;
            DgvUsuario.Columns[2].Visible = false;
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
            }catch(Exception ex)
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
    }
}
