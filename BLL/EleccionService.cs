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
        private List<Eleccion> elecciones;

        public EleccionService() 
        {
            elecciones = new List<Eleccion>();
        }

        public void CrearEleccion(Eleccion eleccion)
        {
            //Simular creacion basica de elecciones
            elecciones.Add(eleccion);
        }

        public List<Eleccion> ObtenerElecciones() 
        {
            return elecciones;
        }
    }
}
