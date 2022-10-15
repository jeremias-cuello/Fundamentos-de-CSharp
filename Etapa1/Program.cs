using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                pais: "Argentina", ciudad: "Buenos Aires");

            Curso curso1 = new Curso()
            {
                Nombre = "101"
            };
            Curso curso2 = new Curso()
            {
                Nombre = "201"
            };
            Curso curso3 = new Curso()
            {
                Nombre = "301"
            };

            Curso[] cursos = new Curso[3];

            cursos[0] = new Curso() { Nombre = "101" };
            cursos[1] = curso2;
            cursos[2] = new Curso() { Nombre = "301" };

            Console.WriteLine(escuela);
            System.Console.WriteLine("===============================");
            ImprimirCursosDoWhile(cursos);
        }

        private static void ImprimirCursosForEach(Curso[] cursos)
        {
            foreach (var c in cursos)
            {
                System.Console.WriteLine($"Nombre: {c.Nombre}, ID: {c.UniqueId}");
            }
        }

        private static void ImprimirCursosWhile(Curso[] cursos)
        {
            var contador = 0;
            while (contador < cursos.Length)
            {
                System.Console.WriteLine($"Nombre: {cursos[contador].Nombre}, ID: {cursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] cursos)
        {
            var contador = 0;
            do
            {
                System.Console.WriteLine($"Nombre: {cursos[contador].Nombre}, ID: {cursos[contador].UniqueId}");
            } while (++contador < cursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] cursos)
        {
            for (int i = 0; i < cursos.Length; i++)
            {
                System.Console.WriteLine($"Nombre: {cursos[i].Nombre}, ID: {cursos[i].UniqueId}");
            }
        }
    }
}