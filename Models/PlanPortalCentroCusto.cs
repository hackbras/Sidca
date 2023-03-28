namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPortalCentroCusto")]
    public partial class PlanPortalCentroCusto
    {
        [Key]
        [StringLength(50)]
        public string cod { get; set; }

        [StringLength(8000)]
        public string Nu_Grupo { get; set; }

        [StringLength(8000)]
        public string No_Grupo { get; set; }

        [StringLength(8000)]
        public string CasoUsoGrupo { get; set; }

        [StringLength(8000)]
        public string Nu_Assunto { get; set; }

        [StringLength(8000)]
        public string No_Assunto { get; set; }

        [StringLength(8000)]
        public string CasoUsoAssunto { get; set; }

        [StringLength(8000)]
        public string CCGeral { get; set; }

        [StringLength(8000)]
        public string CCEspecial { get; set; }

        [StringLength(8000)]
        public string UnidSubsídio { get; set; }

        [StringLength(8000)]
        public string Area { get; set; }
    }
}
