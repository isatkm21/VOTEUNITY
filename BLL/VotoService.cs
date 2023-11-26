using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VotoService
    {

        public static List<Voto> votos = new List<Voto>();
        //public VotoService()
        //{
        //    votos = new List<Voto>();
        //}
        
        
        public static void EmitirVoto(Voto voto)
        {
            try
            {
                votos.Add(voto);
                using (StreamWriter writer = new StreamWriter("Voto.txt", true))
                {
                    string votoString = $"{voto.Id},{voto.IdEleccion},{voto.IdCandidato}";
                    writer.WriteLine(); // Escribir la información del voto en una nueva línea
                }

                Console.WriteLine($"Voto registrado con ID: {voto.Id}");
            }
            catch (Exception ex) 
            {
                Me
            }


        }
    }
}

