using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEvolutiaWorker.Infraestructure.Entities
{
    [Table("USUARIOS")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(16)]
        [Column("usuario")]
        public string Username { get; set; }

        [Required]
        [StringLength(16)]
        [Column("clave")]
        public string Password { get; set; }

        [Required]
        [DefaultValue(2)]
        [Range(1, 3)]
        [Column("nivel")]
        public int Level { get; set; }

        [StringLength(64)]
        [Column("nota")]
        public string? Note { get; set; }
    }
}
