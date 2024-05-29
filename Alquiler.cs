using ProyectoFinal.Modelos;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe especificar la película alquilada.")]
        public int PeliculaId { get; set; }

        [Required(ErrorMessage = "Debe especificar el cliente que alquila la película.")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "La fecha de alquiler es requerida.")]
        public DateTime FechaAlquiler { get; set; }

        [Required(ErrorMessage = "La fecha de devolucion es requerida.")]
        public DateTime FechaDevolucion { get; set; }

        [Required(ErrorMessage = "El monto es requerida.")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "Debe especificar el estado del alquiler.")]
        public bool EstadoAlquiler { get; set; }

        virtual public Pelicula? Pelicula { get; set; }
        virtual public Cliente? Cliente { get; set; }

    }
}