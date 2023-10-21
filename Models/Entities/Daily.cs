using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("DIARIA")]
    public class Daily
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]

        [Column("um_id")]
        public int UmId { get; set; }

        [ForeignKey("UmId")]
        public Um Um { get; set; }

        [Required]
        [Column("hora", TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime Hora { get; set; }

        [Required]
        [Column("vm", TypeName = "float")]
        public float? Vm { get; set; }

        [Required]
        [Column("vn", TypeName = "float")]
        public float? Vn { get; set; }

        [Required]
        [Column("ivm", TypeName = "float")]
        public float? Ivm { get; set; }

        [Required]
        [Column("ivn", TypeName = "float")]
        public float? Ivn { get; set; }

        [Required]
        [Column("ivm_error", TypeName = "float")]
        public float? IvmError { get; set; }

        [Required]
        [Column("ivn_error", TypeName = "float")]
        public float? IvnError { get; set; }

        [Required]
        [Column("ivm_max", TypeName = "float")]
        public float? IvmMax { get; set; }

        [Required]
        [Column("hora_ivm_max", TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime HoraIvmMax { get; set; }

        [Required]
        [Column("ivn_max", TypeName = "float")]
        public float? IvnMax { get; set; }

        [Required]
        [Column("hora_ivn_max", TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime HoraIvnMax { get; set; }

        [Required]
        [Column("qvm_max", TypeName = "float")]
        public float? QvmMax { get; set; }

        [Required]
        [Column("hora_qvm_max", TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime HoraQvmMax { get; set; }

        [Required]
        [Column("qvn_max", TypeName = "float")]
        public float? QvnMax { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column("hora_qvn_max", TypeName = "datetime")]
        public DateTime HoraQvnMax { get; set; }

        [Required]
        [Column("vm_min", TypeName = "float")]
        public float? VmMin { get; set; }

        [Required]
        [Column("hora_vm_min", TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime HoraVmMin { get; set; }

        [Required]
        [Column("vn_min", TypeName = "float")]
        public float? VnMin { get; set; }

        [Required]
        [Column("hora_vn_min", TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime HoraVnMin { get; set; }

        [Required]
        [Column("qvm_min", TypeName = "float")]
        public float? QvmMin { get; set; }

        [Required]
        [Column("hora_qvm_min", TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime HoraQvmMin { get; set; }

        [Required]
        [Column("qvn_min", TypeName = "float")]
        public float QvnMin { get; set; }

        [Required]
        [Column("hora_qvn_min", TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime? HoraQvnMin { get; set; }

        //[Required]
        //[Column("pi")]
        //public float? Pi { get; set; }

        //[Required]
        //[Column("ti")]
        //public float? Ti { get; set; }

        [Required]
        [Column("ntr")]
        public int Ntr { get; set; }

        [Required]
        [Column("ntc")]
        public int Ntc { get; set; }

        [Required]
        [Range(0, 1)]
        [DefaultValue(0)]
        [Column("calculada")]
        public int Calculada { get; set; } = 0;

        [Required]
        [Column("fecha_insercion")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime FechaInser { get; set; }
    }
}
