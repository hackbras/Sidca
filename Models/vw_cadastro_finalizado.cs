namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_cadastro_finalizado
    {
        [Key]
        [StringLength(50)]
        public string Expediente { get; set; }

        [StringLength(50)]
        public string Processo { get; set; }

        [StringLength(50)]
        public string NuAdvogado { get; set; }

        [StringLength(50)]
        public string AreaJud { get; set; }

        [StringLength(50)]
        public string GrupoAssunto { get; set; }

        [StringLength(50)]
        public string DtEntrada { get; set; }

        [StringLength(50)]
        public string VlrCausa { get; set; }

        [StringLength(50)]
        public string DtCausa { get; set; }

        [StringLength(50)]
        public string NuVara { get; set; }

        [StringLength(50)]
        public string NuForo { get; set; }

        [StringLength(50)]
        public string DtFinalizado { get; set; }

        [StringLength(50)]
        public string Finalizado { get; set; }
    }
}
