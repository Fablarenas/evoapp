using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("BITACORA")]
    public class Log
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
        [Column("fecha")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [ForeignKey("IdType")]
        public virtual TypeLog Type { get; set; }

        [Required]
        [Range(0, 20)]
        [Column("tipo")]
        public int IdType { get; set; }

    }
}
