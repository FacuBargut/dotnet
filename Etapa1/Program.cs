using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {   
            var escuela = new Escuela("Natividad del Señor, el padre hignacio es un chanta", 1992, TiposEscuela.Primaria,
                ciudad: "Rosario",pais: "Argentina" 
            );

            var arregloCursos = new Curso [3];

            arregloCursos[0] = new Curso(){
                Nombre = "101"
            };
            
            var curso2 = new Curso(){
                Nombre = "201"
            };

            arregloCursos[1] = curso2;

            var curso3 = new Curso(){
                Nombre = "301"
            };

            arregloCursos[2] = curso3;

            



            Console.WriteLine(escuela);
            System.Console.WriteLine("===============");
            

            ImprimirCursos(arregloCursos);


            

        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            throw new NotImplementedException();
        }
    }
}
