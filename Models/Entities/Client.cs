using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("CLIENTE")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("grupo_id")]
        [Required]
        public int IdGroup { get; set; }

        [ForeignKey("IdGroup")]
        public Group Group { get; set; }

        [Column("cif")]
        [StringLength(9)]
        [Required]
        public string CIF { get; set; }

        [Column("nombre")]
        [StringLength(32)]
        [Required]
        public string Name { get; set; }

        [Column("nota")]
        [StringLength(64)]
        public string? Note { get; set; }

    }
}
