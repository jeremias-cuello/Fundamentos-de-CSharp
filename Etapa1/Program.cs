using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                pais:"Argentina", ciudad: "Buenos Aires");
            
            var curso1 = new Curso(){
                Nombre = "101"
            };

            Curso[] cursos = new Curso[3];

            cursos[0] = new Curso(){
                Nombre = "101"
            }
            
            var curso2 = new Curso(){
                Nombre = "201"
            };

            cursos[1] = curso2;
            cursos[1] = new Curso(){
                Nombre = "301"
            };

            var curso3 = new Curso(){
                Nombre = "301"
            };
            Console.WriteLine(escuela);
            System.Console.WriteLine("===============================");
            System.Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
            System.Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
            System.Console.WriteLine(curso3);
        }
    }
}