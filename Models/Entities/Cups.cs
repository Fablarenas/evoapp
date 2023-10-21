using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("CUPS")]
    public class Cups
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("cliente_id")]
        public int IdClient { get; set; }

        [ForeignKey("IdClient")]
        public Client Client { get; set; }

        [Required]
        [StringLength(20)]
        [Column("cups")]
        public string CupsCode { get; set; }

        [StringLength(64)]
        [Column("suministro")]
        public string? Supply { get; set; }

        [Required]
        [Range(1, 3)]
        [Column("prioridad")]
        [DefaultValue(2)]
        public int Priority { get; set; } = 2;

        [Required]
        [Range(0, 1)]
        [Column("auto")]
        [DefaultValue(1)]
        public int Auto { get; set; } = 1;

        [Required]
        [Range(0, 1)]
        [Column("actv_trama")]
        [DefaultValue(1)]
        public int FrameActv { get; set; } = 1;

        [Required]
        [Range(0, 1)]
        [Column("actv_horaria")]
        [DefaultValue(1)]
        public int HourlyActv { get; set; } = 1;

        [Required]
        [Range(0, 1)]
        [Column("actv_diaria")]
        [DefaultValue(1)]
        public int DailyActv { get; set; } = 1;

        [Required]
        [Range(0, 1)]
        [Column("actv_log")]
        [DefaultValue(1)]
        public int LogActv { get; set; } = 1;

        [Column("nota")]
        [StringLength(64)]
        public string? Note { get; set; }


    }
}
