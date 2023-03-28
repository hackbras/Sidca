namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Codigo_Comarca
    {
        [Key]
        [StringLength(50)]
        public string NU_COMARCA { get; set; }

        [StringLength(50)]
        public string DE_COMARCA { get; set; }

        [StringLength(50)]
        public string NU_UNIDADE_JURIDICA { get; set; }

        [StringLength(50)]
        public string IC_CONSOLIDA { get; set; }
    }
}
