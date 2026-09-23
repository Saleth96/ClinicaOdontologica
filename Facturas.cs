using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("Facturas")]
    public class Factura
    {
        [Key]
        [Column("id_factura", TypeName = "Serial")]
        public int idFactura { get; set; }

        [Column("fecha_emision")]
        [Required]
        public DateTime fechaEmision { get; set; }

        [Column("subtotal", TypeName = "numeric(10,2)")]
        public decimal subtotal { get; set; }

        [Column("impuestos", TypeName = "numeric(10,2)")]
        public decimal impuestos { get; set; }

        [Column("total", TypeName = "numeric(10,2)")]
        public decimal total { get; set; }

        [Column("estado_pago")]
        [MaxLength(20)]
        public string estadoPago { get; set; }

        [Column("id_cita")]
        public int idCita { get; set; }

        [ForeignKey("idCita")]
        public Cita cita { get; set; }
    }
}
