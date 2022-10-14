using System;

namespace CoreEscuela
{
    class CoreEscuela
    {
        public string nombre;
        public string direccion;
        public int añoFundación;
        public string ceo;

        public void Timbrar()
        {
            for (int i = 800; i < (800 + 500 * 5); i += 500)
            {
                Console.Beep(i, 500);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new CoreEscuela();

            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "Cr 9 calle 72";
            miEscuela.añoFundación = 2012;

            Console.WriteLine("TIMBRE");
            
            miEscuela.Timbrar();
        }
    }
}
