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
             string usuarioFilePath = "Usuario.txt";

            public void Guardar(Usuario usuario)
            {
                if (!ObtenerTodos().Any(u => u.Identificacion == usuario.Identificacion))
                {
                    using (StreamWriter writer = new StreamWriter(usuarioFilePath, true))
                    {
                        string line = $"{usuario.Id},{usuario.NombreCompleto},{usuario.Identificacion},{usuario.EsCandidato}";
                        writer.WriteLine(line);
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
                            if (campos.Length == 3) 
                            {
                                int Id = int.Parse(campos[0]);
                                string Nombre = campos[1];
                                string PartidoPolitico = campos[2];

                                Candidato Candidato = new Candidato
                                {
                                    Id = Id,
                                    Nombre = Nombre,
                                    PartidoPolitico = PartidoPolitico
                                };
                                candidatos.Add(Candidato);
                            }
                        }
                    }
                }
                return candidatos;
            }

            public void Guardar(Candidato candidato)
            {
                if (!ObtenerTodos().Any( c => c.Nombre == candidato.Nombre)) 
                {
                    using (StreamWriter writer = new StreamWriter(candidatosFilePath, true))
                    {
                        string line = $"{candidato.Id}, {candidato.Nombre}, {candidato.PartidoPolitico}";
                        writer.WriteLine(line);
                    }
                    //string line = $"{candidato.Id}, {candidato.Nombre}, {candidato.PartidoPolitico}";
                }
                else
                {
                    throw new Exception("Este candidato ya ha sido registrado");
                }
            }
        }

        public interface IVotoRepository
        {
            Voto ObtenerPorId(int id);
            List<Voto> ObtenerTodos();
            void Guardar(Voto voto);
        }
        public class VotoRepository:IVotoRepository
        {
            private string votosFilePath = "Votos.txt";

            public Voto ObtenerPorId(int id)
            {
                return ObtenerTodos().FirstOrDefault(v => v.Id == id);
            }
            public List<Voto> ObtenerTodos()
            {
                List <Voto> votos = new List <Voto>();
                if (File.Exists(votosFilePath)) 
                {
                    using (StreamReader reader = new StreamReader(votosFilePath))
                    {
                        string line;
                        while((line = reader.ReadLine()) != null)
                        {
                            string[] campos = line.Split(',');
                            if (campos.Length == 4) 
                            {
                                int Id = int.Parse(campos[0]);
                                int IdUsuario = int.Parse(campos[1]);
                                int IdEleccion = int.Parse(campos[2]);
                                int IdCandidato = int.Parse(campos[3]);


                                Voto voto = new Voto
                                {
                                    Id = Id,
                                    IdUsuario = IdUsuario,
                                    IdEleccion = IdEleccion,
                                    IdCandidato = IdCandidato,
                                };
                                votos.Add(voto);
                            }
                        }
                    }
                }
                return votos;
            }
            public void Guardar (Voto voto)
            {
                if (!ObtenerTodos().Any(v=> v.IdUsuario == voto.IdUsuario && v.IdEleccion == voto.IdEleccion)) 
                {
                    using (StreamWriter writer = new StreamWriter(votosFilePath, true))
                    {
                        string line = $"{voto.Id}, {voto.IdUsuario}, {voto.IdCandidato}";
                        writer.WriteLine(line);
                    }
                }
                else
                {
                    throw new Exception("Voto duplicado para el mismo usuario y elección");
                }
            }
        }

        public interface IResultadosEleccionRepository
        {
            List<ResultadosElección> ObtenerResultadosPorEleccion(int idEeccion);
            void GuardarResultados(List<ResultadosElección> resultados);
        }

        public class ResultadosEleccionRepository : IResultadosEleccionRepository 
        {
            private string resultadosFilePath = "Resultados.txt";

            public List<ResultadosElección> ObtenerResultadosPorEleccion(int idEleccion)
            {
                return ObtenerTodos().Where(r => r.IdEleccion ==  idEleccion).ToList();
            }
            public List<ResultadosElección> ObtenerTodos()
            {
                List<ResultadosElección> resultados = new List<ResultadosElección>();
                if (File.Exists(resultadosFilePath))
                {
                    using (StreamReader reader = new StreamReader(resultadosFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] campos = line.Split(' ');
                            if (campos.Length == 3)
                            {
                                int IdEleccion = int.Parse(campos[0]);
                                int IdCandidato = int.Parse(campos[1]);
                                int VotosObtenidos = int.Parse(campos[2]);

                                ResultadosElección resultado = new ResultadosElección
                                {
                                    IdEleccion = IdEleccion,
                                    IdCandidato = IdCandidato,
                                    VotosObtenidos = VotosObtenidos,

                                };
                                resultados.Add(resultado);
                            }
                        }
                    }
                }
                return resultados;
            }

            public void GuardarResultados(List<ResultadosElección> resultados)
            {
                using (StreamWriter writer = new StreamWriter(resultadosFilePath)) 
                {
                    foreach (var resultado in resultados)
                    {
                        writer.WriteLine($"{resultado.IdEleccion}, {resultado.IdCandidato}, {resultado.VotosObtenidos}");
                    }
                }
            }
        }
    }
}
