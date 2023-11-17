using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CandidatoService
    {
        public static List<Candidato> candidatos;

        public  CandidatoService() 
        {
            candidatos = new List<Candidato>();
        }
        public static void RegistrarCandidato (Candidato candidato) 
        {
            candidatos.Add(candidato);
        }

        public static List<Candidato> ObtenerCandidato()
        {
            return candidatos;
        }
    }
}
