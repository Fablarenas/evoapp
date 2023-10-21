using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("GRUPO")]
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("nombre")]
        public string Name { get; set; }

        [StringLength(64)]
        [Column("nota")]
        public string? Note { get; set; }
    }
}
