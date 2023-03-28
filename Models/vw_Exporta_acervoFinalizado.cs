namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Exporta_acervoFinalizado
    {
        [Key]
        [StringLength(50)]
        public string Expediente { get; set; }

        [StringLength(50)]
        public string NuAdvogado { get; set; }

        [StringLength(50)]
        public string IdTerceirizacao { get; set; }

        [StringLength(50)]
        public string IdRelevante { get; set; }
    }
}
