namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PreCadastroUniverso")]
    public partial class PreCadastroUniverso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PreCadastroUniverso()
        {
            CadAssunto = new HashSet<CadAssunto>();
            CadConsultaRelevante = new HashSet<CadConsultaRelevante>();
            CadContrato = new HashSet<CadContrato>();
            CadExpedienteVinculado = new HashSet<CadExpedienteVinculado>();
            CadExpedienteVinculado1 = new HashSet<CadExpedienteVinculado>();
            CadExpedienteVinculado2 = new HashSet<CadExpedienteVinculado>();
        }

        [Key]
        [StringLength(50)]
        public string Expediente { get; set; }

        [StringLength(50)]
        public string Processo { get; set; }

        [StringLength(50)]
        public string NoParteJudicial { get; set; }

        [StringLength(50)]
        public string CondicaoParte { get; set; }

        [StringLength(50)]
        public string DtEntrada { get; set; }

        [StringLength(50)]
        public string NuAdvogado { get; set; }

        [StringLength(50)]
        public string AreaJud { get; set; }

        [StringLength(50)]
        public string GrupoAssunto { get; set; }

        [StringLength(50)]
        public string VlrCausa { get; set; }

        [StringLength(50)]
        public string DtCausa { get; set; }

        [StringLength(50)]
        public string NuVara { get; set; }

        [StringLength(50)]
        public string NuForo { get; set; }

        [StringLength(50)]
        public string Comarca { get; set; }

        [StringLength(50)]
        public string CentroCusto { get; set; }

        [StringLength(50)]
        public string UnidSubsidio { get; set; }

        [StringLength(50)]
        public string TpAcao { get; set; }

        [StringLength(50)]
        public string IdTerceirizacao { get; set; }

        [StringLength(50)]
        public string IdRelevante { get; set; }

        [StringLength(50)]
        public string ExpVinculado { get; set; }

        [StringLength(50)]
        public string DtAcervoInfo { get; set; }

        [StringLength(50)]
        public string AcervoInfo { get; set; }

        [StringLength(50)]
        public string DtFinalizado { get; set; }

        [StringLength(50)]
        public string Finalizado { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(8000)]
        public string Expediente_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CadAssunto> CadAssunto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CadConsultaRelevante> CadConsultaRelevante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CadContrato> CadContrato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CadExpedienteVinculado> CadExpedienteVinculado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CadExpedienteVinculado> CadExpedienteVinculado1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CadExpedienteVinculado> CadExpedienteVinculado2 { get; set; }
    }
}
