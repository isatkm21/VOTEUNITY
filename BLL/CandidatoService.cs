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
        private List<Candidato> candidatos;

        public CandidatoService() 
        {
            candidatos = new List<Candidato>();
        }
        public void RegistrarCandidato (Candidato candidato) 
        {
            candidatos.Add(candidato);
        }

        public List<Candidato> ObtenerCandidato()
        {
            return candidatos;
        }
    }
}
