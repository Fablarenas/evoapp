using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("BITACORA_TIPO")]
    public class TypeLog
    {
        [Key]
        [Range(0, 20)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("detalle")]
        public string Detail { get; set; }

    }
}
