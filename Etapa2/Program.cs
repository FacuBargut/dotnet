using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {   
            var escuela = new Escuela("Natividad del Señor", 1992, TiposEscuela.Primaria,
                ciudad: "Rosario",pais: "Argentina"
            );
            escuela.Pais = "Argentina";
            escuela.Ciudad = "Rosario";
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
