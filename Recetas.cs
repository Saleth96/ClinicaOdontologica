using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("Recetas")]
    public class Receta
    {
        [Key]
        [Column("id_receta", TypeName = "Serial")]
        public int idReceta { get; set; }

        [Column("fecha_emision")]
        [Required]
        public DateTime fechaEmision { get; set; }

        [Column("indicaciones")]
        [StringLength(50)]
        [Required]
        public string indicaciones { get; set; }

        [Column("id_cita")]
        [Required]
        public int idCita { get; set; }

        [ForeignKey("")]
        [Column("id_cita")]
        public int idcita {  get; set; }
        public Cita cita { get; set; }
    }
}
