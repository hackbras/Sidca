namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdvogadoCaixa")]
    public partial class AdvogadoCaixa
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string NuEmpregado { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NoAdvogado { get; set; }
    }
}
