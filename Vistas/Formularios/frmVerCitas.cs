using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmVerCitas : Form
    {
        public frmVerCitas()
        {
            InitializeComponent();
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            frmGestiondeCitas ventana = new frmGestiondeCitas(this);
            ventana.Visible = true;
            ventana.Show();
        }

        private void frmVerCitas_Load(object sender, EventArgs e)
        {

        }

        public void MostrarCitas()
        {
            dgvVerCitas.DataSource = null;
            dgvVerCitas.DataSource = Usuario.CargarUsuarios("select *from MostrarTrabajadores");
        }
    }
}
