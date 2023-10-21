using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("DESCARGA")]
    public class Download
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("um_id")]
        public int UmId { get; set; }

        [ForeignKey("UmId")]
        public virtual Um Um { get; set; }

        [Required]
        [Column("ult_trama")]
        [DataType(DataType.DateTime)]
        public DateTime LastFrame { get; set; }

        [Required]
        [Column("ult_horaria")]
        [DataType(DataType.DateTime)]
        public DateTime LastHourly { get; set; }

        [Required]
        [Column("ult_diaria")]
        [DataType(DataType.DateTime)]
        public DateTime LastDaily { get; set; }
    }
}
