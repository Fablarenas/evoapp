using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("SIM")]
    public class Sim
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("numero")]
        public string Number { get; set; }

        [Required]
        [StringLength(32)]
        [Column("telefono")]
        public string Phone { get; set; }

        [Required]
        [StringLength(32)]
        [Column("operadora")]
        public string Operator { get; set; }

        [Required]
        [Column("tipo_contrato")]
        public int IdContract { get; set; }

        [ForeignKey("IdContract")]
        public virtual ContractType? ContractType { get; set; }

        [StringLength(64)]
        [Column("nota")]
        public string? Note { get; set; }
    }
}
