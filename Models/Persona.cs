using System.Runtime.CompilerServices;

namespace Portfolio.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; }


        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            DateTime nacimiento = new DateTime(1979, 1, 11);
            this.Edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
        }
    }
}
