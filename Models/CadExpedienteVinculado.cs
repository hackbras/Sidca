namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CadExpedienteVinculado")]
    public partial class CadExpedienteVinculado
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Expediente { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ExpedienteVinculado { get; set; }

        public virtual PreCadastroUniverso PreCadastroUniverso { get; set; }

        public virtual PreCadastroUniverso PreCadastroUniverso1 { get; set; }

        public virtual PreCadastroUniverso PreCadastroUniverso2 { get; set; }
    }
}
