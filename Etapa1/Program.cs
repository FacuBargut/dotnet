using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {   
            string Nombre = "Natividad del Señor";
            int AñoFundacion = 1992;


            var escuela = new Escuela(Nombre,AñoFundacion);
            escuela.Pais = "Argentina";
            escuela.Ciudad = "Rosario";
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
