using ENTITY;
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

        public interface IUsuarioRepository
        {
            Usuario ObtenerPorId(int id);
            List<Usuario> ObtenerTodos();
            void Guardar(Usuario usuario);
        }
        public class UsuarioRepository : IUsuarioRepository
        {
            private string usuarioFilePath = "Usuario.txt";

            public void Guardar(Usuario usuario)
            {
                if (!ObtenerTodos().Any(u => u.Identificacion == usuario.Identificacion))
                {
                    using (StreamWriter writer = new StreamWriter(usuarioFilePath, true))
                    {
                        string line = $"{usuario.Id},{usuario.NombreCompleto},{usuario.Identificacion},{usuario.EsCandidato}";
                    }
                }
                else
                {
                    throw new Exception("Este usuario ya se encuentra registrado");
                }
            }

            public Usuario ObtenerPorId(int id)
            {
                return ObtenerTodos().FirstOrDefault(u => u.Id == id);
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
                                    EsCandidato = EsCandidato
                                };
                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
                return usuarios;
            }
        }

        public interface IEleccionRepository
        {
            Eleccion ObtenerPorId(int id);
            List<Eleccion> ObtenerTodas();
            void Guardar(Eleccion eleccion);
        }

        public class EleccionRespository : IEleccionRepository
        {
            private string eleccionesFilePath = "Elecciones.txt";
            public Eleccion ObtenerPorId(int id)
            {
                return ObtenerTodas().FirstOrDefault(e => e.Id == id);
            }
            public List<Eleccion> ObtenerTodas()
            {
                List<Eleccion> elecciones = new List<Eleccion>();
                if (File.Exists(eleccionesFilePath))
                {
                    using (StreamReader reader = new StreamReader(eleccionesFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] campos = line.Split(',');
                            if (campos.Length == 3)
                            {
                                int Id = int.Parse(campos[0]);
                                string Nombre = campos[1];
                                DateTime Fecha = DateTime.Parse(campos[2]);

                                Eleccion eleccion = new Eleccion
                                {
                                    Id = Id,
                                    Nombre = Nombre,
                                    Fecha = Fecha,
                                };
                                elecciones.Add(eleccion);
                            }
                        }
                    }
                }
                return elecciones;
            }
            public void Guardar(Eleccion eleccion)
            {
                if (!ObtenerTodas().Any(e => e.Nombre == eleccion.Nombre))
                {
                    using (StreamWriter writer = new StreamWriter(eleccionesFilePath, true))
                    {
                        string line = $"{eleccion.Id}, {eleccion.Nombre}, {eleccion.Fecha:yyyy-MM-dd}";
                        writer.WriteLine(line);
                    }
                }
                else
                {
                    throw new Exception("Ya esixte una eleccion con los mismos datos");
                }
            }
        }

        public interface ICandidatoRepository
        {
            Candidato ObtenerPorId(int id);
            List<Candidato> ObtenerTodos();
            void Guardar (Candidato candidato);
        }
        public class CandidatoRepository : ICandidatoRepository 
        {
            private string candidatosFilePath = "Candidatos.txt";
            public Candidato ObtenerPorId(int id)
            {
                return ObtenerTodos().FirstOrDefault(c=> c.Id == id);
            }
            public List<Candidato> ObtenerTodos()
            {
                List<Candidato>  candidatos = new List<Candidato>();
                if(File.Exists(candidatosFilePath))
                {
                    using (StreamReader reader = new StreamReader(candidatosFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] campos = line.Split(',');
                        }
                    }
                }
            }
        }
    }
}
