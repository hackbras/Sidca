namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Exporta_consultaRelevante
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Expediente { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string ConsultaPortal { get; set; }

        [StringLength(50)]
        public string DtFinalizado { get; set; }

        [StringLength(50)]
        public string Finalizado { get; set; }
    }
}
