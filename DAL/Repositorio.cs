using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repositorio
    {
        public class Usuario
        {
            public int Id { get; set; }
            public string NombreCompleto { get; set; }
            public string Identificacion { get; set; }
            public bool Escandidato { get; set; }
        }
        public interface IUsuarioRepository
        {
            Usuario ObtenerPorId(int id);
            List<Usuario> ObtenerTodos();
            void Guardar (Usuario usuario);
        }
        public class UsuarioRepository : IUsuarioRepository
        {
            private string usuarioFilePath = "Usuario.txt";

            public void Guardar(Usuario usuario)
            {
                if (!ObtenerTodos().Any(u=> u.Identificacion==usuario.Identificacion))
                {
                    using (StreamWriter writer = new StreamWriter(usuarioFilePath,true))
                    {
                        string line = $"{usuario.Id},{usuario.NombreCompleto},{usuario.Identificacion},{usuario.Escandidato}";
                    }
                }
                else
                {
                    throw new Exception("Este usuario ya se encuentra registrado");
                }
            }

            public Usuario ObtenerPorId(int id)
            {
                return ObtenerTodos().FirstOrDefault(u=> u.Id == id);
            }
            public List<Usuario> ObtenerTodos()
            {
                List<Usuario> usuarios = new List<Usuario>();
                if (File.Exists(usuarioFilePath))
                {
                    using (StreamReader reader = new StreamReader(usuarioFilePath)) 
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] campos = line.Split(',');
                            if (campos.Length == 4)
                            {
                                int Id = int.Parse(campos[0]);
                                string NombreCompleto = campos[1];
                                string Identificacion = campos[2];
                                bool EsCandidato = bool.Parse(campos[3]);


                                Usuario usuario = new Usuario()
                                {
                                    Id = Id,
                                    NombreCompleto = NombreCompleto,
                                    Identificacion = Identificacion,
                                    Escandidato = EsCandidato
                                };
                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
                return usuarios;
            }
        }
    }
}
