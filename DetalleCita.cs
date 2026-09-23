using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("DetallesCita")]
    public class DetalleCita
    {
        [Key]
        [Column("id_detalle_cita", TypeName = "Serial")]
        public int idDetalleCita { get; set; }

        [Column("id_cita")]
        [Required]
        public int idCita { get; set; }

        [ForeignKey("idCita")]
        public Cita cita { get; set; }

        [Column("id_tratamiento")]
        public int idTratamiento { get; set; }

        [ForeignKey("idTratamiento")]
        public Tratamiento tratamiento { get; set; }

        [Column("costo_aplicado")]
        public decimal costoAplicado { get; set; }

        [Column("observaciones")]
        [MaxLength(50)]
        public string observaciones { get; set; }
    }
}
