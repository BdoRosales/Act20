using ProyectoFinal.Modelos;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string? Telefono { get; set; }

        [MaxLength(50, ErrorMessage = "Los detalles de membresía no pueden exceder los 50 caracteres.")]
        public string? DetallesMembresia { get; set; }
        public ICollection<Alquiler>? Alquileres { get; set; }
    }
}