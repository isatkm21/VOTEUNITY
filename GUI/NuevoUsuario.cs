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
    public partial class NuevoUsuario : Form
    {
        private UsuarioRepository repo;
        public NuevoUsuario()
        {
            InitializeComponent();
            repo = new UsuarioRepository();
        }

        
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ///*Usuario*/ usuario = new Usuario();

            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Id = comboBoxId.SelectedItem.ToString();
            string Documento = txtDocumento.Text;

            string mensaje = $"Nombre: {Nombres}\nApellido: {Apellidos}\nId: {Id}\nDocumento: {Documento} ha sido registrado.";
            MessageBox.Show(mensaje);
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
