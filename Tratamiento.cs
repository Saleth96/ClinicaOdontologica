using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaOdontologica
{
    [Table("tratamiento")]
    public class Tratamiento
    {
        [Key]
        [Column("id_tratamiento")]
        public int idTratamiento { get; set; }
        [Column("nombre_tratamiento")]
        [MaxLength(50)]
        [Required]
        public int nombreTratamiento { get; set; }
        [Column(TypeName ="numero(10,2)")]
        [Required]

        public decimal costoBase {  get; set; }
        [Column("duracion_estimada_minutos")]
        [Required]
        public TimeOnly duracionEstimadaMinutos { get; set; }

    }
}
