namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Codigo_Acao
    {
        [Key]
        [StringLength(50)]
        public string NU_ACAO { get; set; }

        [StringLength(50)]
        public string DE_ACAO { get; set; }
    }
}
