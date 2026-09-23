using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("Especialidades")]
    public class Especialidades
    {
        [Key]
        [Column("id_especialidad")]
        public int idEspecialidad { get; set; }

        [Column("nombre_especialidad")]
        [MaxLength(50)]
        public string nombreEspecialidad { get; set; }

        [Column("descripcion")]
        [StringLength(200, ErrorMessage = "El campo 'Descripcion' no puede exceder los 200 caracteres")]
        public string descripcion { get; set; }
    }
}
