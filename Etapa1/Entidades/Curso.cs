using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; } = "";
        public string UniqueId { get; private set; }
        public Jornada.Tipos Tipo { get; set; }
        public Curso () => UniqueId = Guid.NewGuid().ToString();

    }
}