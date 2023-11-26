using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DAL;

namespace GUI
{
    public partial class NuevoUsuario : Form
    {
        UsuarioRepository repo;
        public NuevoUsuario()
        {
            InitializeComponent();
            repo = new UsuarioRepository();
        }

        
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string 

            ///*Usuario*/ usuario = new Usuario();
            //try
            //{
            //    Usuario nuevousuario = new Usuario
            //    {
            //        Id = txtDocumento.Text,
            //        NombreCompleto = txtNombres.Text + " " + txtApellidos.Text,
            //        Apellidos = txtApellidos.Text,
            //        Identificacion = txtDocumento,
            //    }

            //    UsuarioRepository repo = new UsuarioRepository();
            //    repo.Guardar(nuevoUsuario);
            //    DialogResult result = MessageBox.Show("Usuario almacenado correctamente. ¿Desea volver al inicio de sesión?", "Éxito", MessageBoxButtons.OKCancel);

            //    if (result == DialogResult.OK) 
            //    {
            //        Loguin loguin= new Loguin();
            //        loguin.Show();
            //        this.Hide();
            //    }
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show($"Error al guardar el usuario. ");
            //}
            
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
