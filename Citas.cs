using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("Citas")]
    public class Cita
    {
        [Key]
        [Column("id_cita")]
        public int idCita { get; set; }

        [Column("fecha_cita")]
        public DateTime fechaCita { get; set; }

        [Column("motivo")]
        [MaxLength(25)]
        public string motivo { get; set; }

        [Column("estado_cita")]
        [MaxLength(20)]
        public string estadoCita { get; set; }

        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [ForeignKey("idPaciente")]
        public Pacientes paciente { get; set; }

        [Column("id_odontologo")]
        public int idOdontologo { get; set; }

        [ForeignKey("idOdontologo")]
        public Odontologo odontologo { get; set; }

        [Column("id_consultorio")]
        public int idConsultorio { get; set; }

        [ForeignKey("idConsultorio")]
        public Consultorio consultorio { get; set; }
    }
}
