﻿using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
        public class UsuarioService
        {
            public static List<Usuario> usuarios;

            public UsuarioService()
            {
                usuarios = new List<Usuario>();

            }

            public static bool AutenticarUsuario(string NombreUsuario, string Contraseña)
            {
                var usuario = usuarios.FirstOrDefault(u => u.NombreCompleto == NombreUsuario);
                return usuario != null;
            }

            public static void RegistrarUsuario(Usuario usuario)
            {
                //simular registro basico de usuario
                usuarios.Add(usuario);

            }

            public void RegistrarUsuario(UsuarioService votante)
            {
                throw new NotImplementedException();
            }
        }
}
