using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("CONFIGURACION")]
    public class Configuration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [DefaultValue(2)]
        [Range(1, 6)]
        [Column("num_intentos")]
        public int NumberOfAttempts { get; set; } = 2;

        [Required]
        [DefaultValue(2)]
        [Range(1, 5)]
        [Column("min_espera")]
        public int WaitMinutes { get; set; } = 2;

        [Required]
        [DefaultValue(1)]
        [Column("trama_general")]
        [Range(0, 1)]
        public int GeneralFrame { get; set; } = 1;
    }
}
