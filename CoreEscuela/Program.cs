using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo;


        public void Timbrar()
        {
            //Todo
            Console.Beep(10000, 3000);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var miEscuela = new Escuela();
            miEscuela.nombre = "Natividad del Señor";
            miEscuela.direccion = "Parque Field";
            miEscuela.añoFundacion = 1939;
            Console.WriteLine("TIMBRE: ");
            miEscuela.Timbrar();
        }
    }
}
