using Portfolio.Models;

namespace Portfolio.Servicios
{
    public class RepositorioProyectos
    {

        public List<Proyecto> proyectos { get; } 

        public RepositorioProyectos()
        {
            this.proyectos = obtenerProyectos();
        }
        private List<Proyecto> obtenerProyectos()
        {
            return new List<Proyecto> { new Proyecto
            {
                Titulo = "Buscador de país",
                Descripcion = "Aplicación desarrollada con Angular, busca información de los países utilizando el API REST restcountries.com",
                ImageURL = "/imagenes/buscador-de-pais.png",
                Link = "https://buscador-de-pais.netlify.app/"
            },
            new Proyecto
            {
                Titulo = "Buscador de país",
                Descripcion = "Aplicación desarrollada con Angular, busca la mejor ruta para llegar a un destino en menor tiempo, se utilizó la librería de https://www.mapbox.com/",
                ImageURL = "/imagenes/buscador-de-pais.png",
                Link = "https://como-llegar.netlify.app/"
            },
            new Proyecto
            {
                Titulo = "Sistema de tickets",
                Descripcion = "Sistema que permite hacer solicitudes de soporte técnico a un administrador. Se utilizó Angular para el Frontend y Nestjs para el backend",
                ImageURL = "/imagenes/tickets.png",
                Link = "https://soporte-fba.netlify.app/#/login"
            }
            };
        }
    }
}
