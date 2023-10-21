using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("HORARIA")]
    public class Hourly
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("um_id")]
        public int UmId { get; set; }

        [ForeignKey("UmId")]
        public virtual Um? Um { get; set; }

        [Required]
        [Column("hora")]
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }

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
        [Column("qvm", TypeName = "float")]
        public float? Qvm { get; set; }

        [Required]
        [Column("qvn", TypeName = "float")]
        public float? Qvn { get; set; }

        [Required]
        [Column("p", TypeName = "float")]
        public float? P { get; set; }

        [Required]
        [Column("t", TypeName = "float")]
        public float? T { get; set; }

        [Required]
        [Column("ntr")]
        public int? Ntr { get; set; }

        [Required]
        [Column("ntc")]
        public int? Ntc { get; set; }

        [Required]
        [Column("fecha_insercion")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime InsertDate { get; set; }

    }
}
