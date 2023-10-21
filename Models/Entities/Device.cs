using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("DISPOSITIVO")]
    public class Device
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("sim_id")]
        public int IdSim { get; set; }

        [ForeignKey("IdSim")]
        public Sim Sim { get; set; }

        [StringLength(32)]
        [Column("nombre")]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        [Column("marca")]
        public string Brand { get; set; }

        [Required]
        [StringLength(32)]
        [Column("modelo")]
        public string Model { get; set; }

        [StringLength(32)]
        [Column("serial")]
        public string Serial { get; set; }

        [StringLength(32)]
        [Column("ip_router")]
        public string? RouterIp { get; set; }

        [Column("puerto_router")]
        public int? RouterPort { get; set; }

        [StringLength(32)]
        [Column("usuario")]
        public string? User { get; set; }

        [StringLength(32)]
        [Column("clave")]
        public string? Password { get; set; }

        [StringLength(64)]
        [Column("nota")]
        public string? Note { get; set; }
    }
}
