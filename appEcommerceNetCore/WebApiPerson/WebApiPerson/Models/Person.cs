using System.ComponentModel.DataAnnotations;

namespace WebApiPerson.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int Age { get; set; }


    }
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string? Descripcion { get; set; }

        [Required]
        public string? Categoria { get; set; }

        public decimal PrecioUnitario { get; set; }

        public bool Active { get; set; }
    }

}
