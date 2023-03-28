namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Codigo_Unidade
    {
        [Key]
        [StringLength(50)]
        public string NU_UNIDADE { get; set; }

        [StringLength(50)]
        public string NO_UNIDADE { get; set; }

        [StringLength(50)]
        public string DT_FIM { get; set; }

        [StringLength(50)]
        public string CD_ADM { get; set; }

        [StringLength(50)]
        public string IC_ATIVA { get; set; }
    }
}
