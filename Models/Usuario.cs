using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsApi.Models
{
    public class Usuario
    {
        [Key]
        [Column("Autor_ID")]
        public int AutorID { get; set; }

        [Column("nombres")]
        public string? Nombres { get; set; }

        [Column("nombre_usuario")]
        [Required]
        public string? NombreUsuario { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("contrasena")]
        public string? Contrasena { get; set; }
    }
}
