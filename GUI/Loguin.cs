using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraeña = txtContraseña.Text;

           
            // bool autenticado = (nombreUsuario, contraeña);

           /* if (nombreUsuario.Length) 
            {
                MessageBox.Show("Inicio de sesión exitoso");
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
           */
           
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.Show();

            MessageBox.Show("Inicio de registro de nuevo usuario");

        }

        //private void button1_MouseClick(object sender, MouseEventArgs e)
        //{

        //}
    }
}
