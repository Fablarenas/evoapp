using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("CONTRATO_TIPO")]
    public class ContractType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("valor")]
        public int Id { get; set; }

        [Required]
        [Column("detalle")]
        public string? Detail { get; set; }
    }
}
