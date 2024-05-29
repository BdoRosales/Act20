using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelos
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "El año es requerido")]
        public int AñoLanzamiento { get; set; }

        [Required(ErrorMessage = "El género es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El género no puede exceder los 100 caracteres.")]
        public string? Genero { get; set; }

        [Required(ErrorMessage = "El director es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Director { get; set; }

        [Required(ErrorMessage = "Los actores principales son obligatorios.")]
        [MaxLength(200, ErrorMessage = "Los actores principales no pueden exceder los 200 caracteres.")]
        public string? ActoresPrincipales { get; set; }

        [Required(ErrorMessage = "La sinopsis es requerida")]
        public string? Sinopsis { get; set; }

        [Required(ErrorMessage = "El precio de alquiler es requerido")]
        public decimal PrecioAlquiler { get; set; }

        [Required(ErrorMessage = "Debe especificar si la película está disponible para alquiler.")]
        public bool DisponibleParaAlquiler { get; set; }

        public ICollection<Alquiler>? Alquileres { get; set; }
    }
}