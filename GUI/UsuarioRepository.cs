using System;
using System.Windows.Forms;

namespace GUI
{
    public class UsuarioRepository
    {
        public string NombreCompleto { get; internal set; }
        public string Apellidos { get; internal set; }
        public bool Identificacion { get; internal set; }
        public TextBox Id { get; internal set; }

        internal void Guardar(UsuarioRepository nuevoUsuario)
        {
            throw new NotImplementedException();
        }
    }
}