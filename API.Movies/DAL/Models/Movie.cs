using System.ComponentModel.DataAnnotations;

namespace API.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required] //Este data annotation indica que el campo es obligatorio
        [Display(Name = "Nombre de la Pelicula")] //Me sirve para personalizar el nombre que se muestra en las vistas o mensajes de error
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Clasification { get; set; }

    }
}