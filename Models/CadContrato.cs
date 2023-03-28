namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CadContrato")]
    public partial class CadContrato
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Expediente { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string NoParte { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NuContrato { get; set; }

        public virtual PreCadastroUniverso PreCadastroUniverso { get; set; }
    }
}
