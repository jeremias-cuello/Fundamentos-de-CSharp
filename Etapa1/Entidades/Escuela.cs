using System.Text;
namespace CoreEscuela.Entidades
{
    class Escuela
    {
        private string nombre = "";
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; } = "";
        public string Ciudad { get; set; } = "";

        public TiposEscuela TipoEscuela;

        public Escuela (string nombre = "n/n", int año = 2000) => (this.Nombre, this.AñoDeCreacion) = (nombre, año);
        public Escuela (string nombre,
                        int año,
                        TiposEscuela tipo,
                        string pais = "",
                        string ciudad = "")
        {
            (this.Nombre, this.AñoDeCreacion) = (nombre, año);
            this.Pais = pais;
            this.Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, Tipo: {this.TipoEscuela}\nPais: {this.Pais}, Ciudad: {this.Ciudad}";
        }
    }
}