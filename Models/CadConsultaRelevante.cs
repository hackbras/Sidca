namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CadConsultaRelevante")]
    public partial class CadConsultaRelevante
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Expediente { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string ConsultaPortal { get; set; }

        public virtual PreCadastroUniverso PreCadastroUniverso { get; set; }
    }
}
