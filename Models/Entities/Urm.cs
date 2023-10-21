using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("URM")]
    public class Urm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("dispositivo_id")]
        [Required]
        public int DeviceId { get; set; }

        [ForeignKey("DeviceId")]
        public Device Device { get; set; }

        [Required]
        [Column("numero")]
        public int? Number { get; set; }

        [Required]
        [StringLength(32)]
        [Column("marca")]
        public string Brand { get; set; }

        [Range(0, 23)]
        [DefaultValue(6)]
        [Column("hora_cierre")]
        public int? ClosingHour { get; set; } = 6;

        [StringLength(32)]
        [Column("contacto")]
        public string? Contact { get; set; }

        [StringLength(32)]
        [Column("telefono")]
        public string? Phone { get; set; }

        [StringLength(32)]
        [Column("email")]
        public string? Email { get; set; }

        [StringLength(32)]
        [Column("usuario")]
        public string? User { get; set; }

        [StringLength(32)]
        [Column("clave")]
        public string? Password { get; set; }

        [Required]
        [StringLength(32)]
        [Column("ip_vpn")]
        public string? VpnIP { get; set; }

        [Required]
        [Column("puerto_vpn")]
        [DefaultValue(80)]
        public int? VpnPort { get; set; } = 80;

        [StringLength(32)]
        [DefaultValue("10.0.0.10")]
        [Column("ip_datalogger")]
        public string? DataLoggerIp { get; set; } = "10.0.0.10";

        [StringLength(64)]
        [Column("nota")]
        public string? Note { get; set; }


    }
}
