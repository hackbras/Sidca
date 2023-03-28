namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Codigo_Condicao_Parte
    {
        [Key]
        [StringLength(50)]
        public string NU_CONDICAO_PARTE { get; set; }

        [StringLength(50)]
        public string DE_CONDICAO_PARTE { get; set; }
    }
}
