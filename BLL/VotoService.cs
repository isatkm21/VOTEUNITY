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
        public static List<Voto> votos;
        public VotoService()
        {
            votos = new List<Voto>();
        }

        public static void EmitirVoto (Voto voto) 
        {
            votos.Add(voto);
        }
    }
}
