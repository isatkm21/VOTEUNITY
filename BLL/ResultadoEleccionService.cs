using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ResultadoEleccionService
    {
        public static List<ResultadosElección> resultados;
        public  ResultadoEleccionService() 
        {
            resultados = new List<ResultadosElección>();

        }

        public static List<ResultadosElección> ObtenerResultadosPorEleccion(int IdEleccion)
        {
            return resultados.Where(r=> r.IdEleccion == IdEleccion).ToList();
        }
    }
}
