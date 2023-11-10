using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VotoService
    {
        private List<Voto> votos;
        public VotoService()
        {
            votos = new List<Voto>();
        }

        public void EmitirVoto (Voto voto) 
        {
            votos.Add(voto);
        }
    }
}
