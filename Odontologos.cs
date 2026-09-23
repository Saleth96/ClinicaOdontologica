using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("Odontologos")]
    public class Odontologo
    {
        [Key]
        [Column("id_odontologo")]
        public int idOdontologo { get; set; }

        [Column("nombres")]
        [MaxLength(50)]
        [Required]

        public string nombres { get; set; }

        [Column("apellidos")]
        [MaxLength(50)]
        [Required]
        public string apellidos { get; set; }

        [Column("registro_medico")]
        [MaxLength(20)]
        [Required]
        public string registroMedico { get; set; }

        [Column("id_especialidad")]
        public int idEspecialidad { get; set; }

        [ForeignKey("idEspecialidad")]
        public Odontologo especialidad { get; set; }
    }
}
