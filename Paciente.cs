using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("Paciente")]
    public class Paciente
    {
        [Key]
        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [Column("dni")]
        [MaxLength(10)]
        public string dni { get; set; }
        [Column("nombres")]
        [MaxLength(25)]
        public string nombres { get; set; }

        [Column("apellidos")]
        [MaxLength(25)]
        public string apellidos { get; set; }

        [Column("fecha_nacimiento")]
        public DateTime fechaNacimiento { get; set; }

        [Column("email")]
        [MaxLength(25)]
        public string email { get; set; }

        [Column("telefono")]
        [MaxLength(10)]
        public string telefono { get; set; }
    }
}
