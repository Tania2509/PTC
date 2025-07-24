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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "1234" && txtCorreo.Text == "Administrador")
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                frmDashboardAdministrador ventana = new frmDashboardAdministrador(this);
                this.Hide();
                ventana.Show();
            }
            else if (txtContraseña.Text == "12345" && txtCorreo.Text == "Asistente")
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                frmDashboardAsistente ventana = new frmDashboardAsistente(this);
                this.Hide();
                ventana.Show();
            }
            else if (txtContraseña.Text == "1200" && txtCorreo.Text == "Doctor")
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                frmDashboardDoctor ventana = new frmDashboardDoctor(this);
                this.Hide();
                ventana.Show();
            }

            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }
        }
    }
}
