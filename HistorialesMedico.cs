using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("Historiales Medicos")]
    public class HistorialesMedico
    {
        [Key]
        [Column("id_Historial",TypeName="Serial")]
        public int idHistorial {  get; set; }

        [Column("alergias")]
        [MaxLength(30)]
        public string alergias { get; set; }
        [Column("enfermedadesPrevias")]
        [MaxLength(30)]
        public string enfermedadesPrevias { get; set; }

        [Column("tipo_Sangre")]
        [MaxLength(4)]
        public string tipoSangre { get; set; }
        [ForeignKey("")]
        [Column("id_paciente")]
        public int idPaciente {  get; set; }
        public Pacientes paciente { get; set; }
    }
}
