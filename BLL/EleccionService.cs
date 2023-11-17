using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EleccionService
    {
        public static List<Eleccion> elecciones;

        public  EleccionService() 
        {
            elecciones = new List<Eleccion>();
        }

        public static void CrearEleccion(Eleccion eleccion)
        {
            //Simular creacion basica de elecciones
            elecciones.Add(eleccion);
        }

        public static List<Eleccion> ObtenerElecciones() 
        {
            return elecciones;
        }
    }
}
