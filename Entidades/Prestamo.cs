using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prestamos.Entidades
{
    public class Prestamo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; }
        public int PersonaId { get; set; }
        public string Concepto { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }
    }
}