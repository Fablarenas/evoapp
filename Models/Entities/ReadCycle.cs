using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEvolutiaWorker.Infraestructure.Entities
{

    [Table("CICLO_LECTURA")]
    public class ReadCycle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("cups_id")]
        public int CupsId { get; set; }

        [Required]
        [Column("um_id")]
        public int UmId { get; set; }

        [Required]
        [Column("prox_trama")]
        public DateTime NextFrame { get; set; }

        [Required]
        [Column("prox_horaria")]
        public DateTime NextHourly { get; set; }

        [Required]
        [Column("prox_diaria")]
        public DateTime NextDaily { get; set; }

        [Required]
        [Column("num_intentos_horaria")]
        public int HourlyTries { get; set; } = 0;

        [Required]
        [Column("num_intentos_diaria")]
        public int DailyTries { get; set; } = 0;

        [Required]
        [Column("num_intentos_trama")]
        public int LastFrameTries { get; set; } = 0;

        [Required]
        [Range(1, 3)]
        [Column("estado_horaria")]
        public int HourlyState { get; set; } = 0;

        [Required]
        [Range(1, 3)]
        [Column("estado_diaria")]
        public int DailyState { get; set; } = 0;

        [Required]
        [Range(1, 3)]
        [Column("estado_trama")]
        public int LastFrameState { get; set; } = 0;

        [ForeignKey("CupsId")]
        public Cups Cups { get; set; }

        [ForeignKey("UmId")]
        public Um Um { get; set; }
    }
}
