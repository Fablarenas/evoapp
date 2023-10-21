using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("UM")]
    public class Um
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("urm_id")]
        public int UrmId { get; set; }

        [ForeignKey("UrmId")]
        public Urm Urm { get; set; }

        [Required]
        [Column("cups_id")]
        public int CupsId { get; set; }

        [ForeignKey("CupsId")]
        public Cups Cups { get; set; }

        [Required]
        [Column("um_urm")]
        public int Um_Urm { get; set; }

        [Required]
        [Column("um_set")]
        public int Um_Set { get; set; }

        [StringLength(64)]
        [Column("nota")]
        public string? Note { get; set; }

        [NotMapped]
        public string Usuario { get; set; }

        [NotMapped]
        public string Contraseña { get; set; }
        [NotMapped]
        public string Url { get; set; }
    }
}
