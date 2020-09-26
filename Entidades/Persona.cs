using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prestamos.Entidades
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public double Balance { get; set; }
    }
}