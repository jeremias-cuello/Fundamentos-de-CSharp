namespace CoreEscuela.Entidades
{
    class Escuela
    {
        private string nombre;
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public Escuela (string nombre, int año) => (this.Nombre, this.AñoDeCreacion) = (nombre, año);
    }
}