
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace BLL
{
    public class ResultadoEleccionService
    {
        }
        public static List<ResultadosElección> resultados = new List<ResultadosElección>();
        //public  ResultadoEleccionService() 
        //{
        //    resultados = new List<ResultadosElección>();

        //}

        public static List<ResultadosElección> ObtenerResultadosPorEleccion(int IdEleccion)
        {
            return resultados.Where(r=> r.IdEleccion == IdEleccion).ToList();
        }

        public static void GuardarResultados()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter ("Resultados.txt", true))
                {
                    foreach (var resultado in resultados)
                    {
                        string resultadoString = $"{resultado.IdEleccion}, {resultado.IdCandidato}, {resultado.VotosObtenidos}";
                        writer.WriteLine ();
                    }
                }
            }
            catch { }
        }
    }
}
