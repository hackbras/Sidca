namespace SidcaMrv2.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class vw_cadAdvogadoAcervo_finalizado
    {
        [Key]
        [StringLength(50)]
        public string Expediente { get; set; }

        [StringLength(50)]
        public string Processo { get; set; }

        [StringLength(50)]
        public string DtEntrada { get; set; }

        [StringLength(50)]
        public string NoParteJudicial { get; set; }

        [StringLength(50)]
        public string ExpVinculado { get; set; }

        [StringLength(50)]
        public string NuAdvogado { get; set; }

        [StringLength(50)]
        public string IdTerceirizacao { get; set; }

        [StringLength(50)]
        public string IdRelevante { get; set; }

        [StringLength(50)]
        public string AcervoInfo { get; set; }

        [StringLength(50)]
        public string DtAcervoInfo { get; set; }
    }
}
