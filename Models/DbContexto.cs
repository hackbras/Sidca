namespace SidcaMrv2.Models
{
    using System.Data.Entity;

    public partial class DbContexto : DbContext
    {
        public DbContexto()
            : base("name=DbContexto")
        {
        }

        public virtual DbSet<AdvogadoCaixa> AdvogadoCaixa { get; set; }
        public virtual DbSet<CadAdvogadoContra> CadAdvogadoContra { get; set; }
        public virtual DbSet<CadAssunto> CadAssunto { get; set; }
        public virtual DbSet<CadConsultaRelevante> CadConsultaRelevante { get; set; }
        public virtual DbSet<CadContrato> CadContrato { get; set; }
        public virtual DbSet<CadExpedienteVinculado> CadExpedienteVinculado { get; set; }
        public virtual DbSet<CadParteJudicial> CadParteJudicial { get; set; }
        public virtual DbSet<Codigo_Acao> Codigo_Acao { get; set; }
        public virtual DbSet<Codigo_Comarca> Codigo_Comarca { get; set; }
        public virtual DbSet<Codigo_Condicao_Parte> Codigo_Condicao_Parte { get; set; }
        public virtual DbSet<Codigo_Foro> Codigo_Foro { get; set; }
        public virtual DbSet<Codigo_Unidade> Codigo_Unidade { get; set; }
        public virtual DbSet<PlanPortalCentroCusto> PlanPortalCentroCusto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<PreCadastroUniverso> PreCadastroUniverso { get; set; }
        public virtual DbSet<vw_cadAdvogadoAcervo_finalizado> vw_cadAdvogadoAcervo_finalizado { get; set; }
        public virtual DbSet<vw_cadastro_finalizado> vw_cadastro_finalizado { get; set; }
        public virtual DbSet<vw_area> vw_area { get; set; }
        public virtual DbSet<vw_Exporta_acervoFinalizado> vw_Exporta_acervoFinalizado { get; set; }
        public virtual DbSet<vw_Exporta_advogadoContraFinalizado> vw_Exporta_advogadoContraFinalizado { get; set; }
        public virtual DbSet<vw_Exporta_assuntoFinalizado> vw_Exporta_assuntoFinalizado { get; set; }
        public virtual DbSet<vw_Exporta_CadContratoFinalizado> vw_Exporta_CadContratoFinalizado { get; set; }
        public virtual DbSet<vw_Exporta_CadExpedienteVinculadoFinalizado> vw_Exporta_CadExpedienteVinculadoFinalizado { get; set; }
        public virtual DbSet<vw_Exporta_consultaRelevante> vw_Exporta_consultaRelevante { get; set; }
        public virtual DbSet<vw_Exporta_ExpedienteFinalizado> vw_Exporta_ExpedienteFinalizado { get; set; }
        public virtual DbSet<vw_Exporta_ParteJudicialFinalizado> vw_Exporta_ParteJudicialFinalizado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdvogadoCaixa>()
                .Property(e => e.NuEmpregado)
                .IsUnicode(false);

            modelBuilder.Entity<AdvogadoCaixa>()
                .Property(e => e.NoAdvogado)
                .IsUnicode(false);

            modelBuilder.Entity<CadAdvogadoContra>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<CadAdvogadoContra>()
                .Property(e => e.AdvogadoContra)
                .IsUnicode(false);

            modelBuilder.Entity<CadAdvogadoContra>()
                .Property(e => e.NuOAB)
                .IsUnicode(false);

            modelBuilder.Entity<CadAssunto>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<CadAssunto>()
                .Property(e => e.Assunto)
                .IsUnicode(false);

            modelBuilder.Entity<CadConsultaRelevante>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<CadConsultaRelevante>()
                .Property(e => e.ConsultaPortal)
                .IsUnicode(false);

            modelBuilder.Entity<CadContrato>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<CadContrato>()
                .Property(e => e.NoParte)
                .IsUnicode(false);

            modelBuilder.Entity<CadContrato>()
                .Property(e => e.NuContrato)
                .IsUnicode(false);

            modelBuilder.Entity<CadExpedienteVinculado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<CadExpedienteVinculado>()
                .Property(e => e.ExpedienteVinculado)
                .IsUnicode(false);

            modelBuilder.Entity<CadParteJudicial>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<CadParteJudicial>()
                .Property(e => e.NoParteJudicial)
                .IsUnicode(false);

            modelBuilder.Entity<CadParteJudicial>()
                .Property(e => e.CpfCnpj)
                .IsUnicode(false);

            modelBuilder.Entity<CadParteJudicial>()
                .Property(e => e.CondicaoParte)
                .IsUnicode(false);

            modelBuilder.Entity<CadParteJudicial>()
                .Property(e => e.Matricula)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Acao>()
                .Property(e => e.NU_ACAO)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Acao>()
                .Property(e => e.DE_ACAO)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Comarca>()
                .Property(e => e.NU_COMARCA)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Comarca>()
                .Property(e => e.DE_COMARCA)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Comarca>()
                .Property(e => e.NU_UNIDADE_JURIDICA)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Comarca>()
                .Property(e => e.IC_CONSOLIDA)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Condicao_Parte>()
                .Property(e => e.NU_CONDICAO_PARTE)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Condicao_Parte>()
                .Property(e => e.DE_CONDICAO_PARTE)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Foro>()
                .Property(e => e.NU_FORO)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Foro>()
                .Property(e => e.DE_FORO)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Unidade>()
                .Property(e => e.NU_UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Unidade>()
                .Property(e => e.NO_UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Unidade>()
                .Property(e => e.DT_FIM)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Unidade>()
                .Property(e => e.CD_ADM)
                .IsUnicode(false);

            modelBuilder.Entity<Codigo_Unidade>()
                .Property(e => e.IC_ATIVA)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.cod)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.Nu_Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.No_Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.CasoUsoGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.Nu_Assunto)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.No_Assunto)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.CasoUsoAssunto)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.CCGeral)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.CCEspecial)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.UnidSubsídio)
                .IsUnicode(false);

            modelBuilder.Entity<PlanPortalCentroCusto>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Gestor)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Setor)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.ComputadorNome)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.Processo)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.NoParteJudicial)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.CondicaoParte)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.DtEntrada)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.NuAdvogado)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.AreaJud)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.GrupoAssunto)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.VlrCausa)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.DtCausa)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.NuVara)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.NuForo)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.Comarca)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.CentroCusto)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.UnidSubsidio)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.TpAcao)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.IdTerceirizacao)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.IdRelevante)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.ExpVinculado)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.DtAcervoInfo)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.AcervoInfo)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.DtFinalizado)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.Finalizado)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .Property(e => e.Expediente_id)
                .IsUnicode(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .HasMany(e => e.CadAssunto)
                .WithRequired(e => e.PreCadastroUniverso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .HasMany(e => e.CadConsultaRelevante)
                .WithRequired(e => e.PreCadastroUniverso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .HasMany(e => e.CadContrato)
                .WithRequired(e => e.PreCadastroUniverso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .HasMany(e => e.CadExpedienteVinculado)
                .WithRequired(e => e.PreCadastroUniverso)
                .HasForeignKey(e => e.Expediente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .HasMany(e => e.CadExpedienteVinculado1)
                .WithRequired(e => e.PreCadastroUniverso1)
                .HasForeignKey(e => e.ExpedienteVinculado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreCadastroUniverso>()
                .HasMany(e => e.CadExpedienteVinculado2)
                .WithRequired(e => e.PreCadastroUniverso2)
                .HasForeignKey(e => e.Expediente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.Processo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.DtEntrada)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.NoParteJudicial)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.ExpVinculado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.NuAdvogado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.IdTerceirizacao)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.IdRelevante)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.AcervoInfo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadAdvogadoAcervo_finalizado>()
                .Property(e => e.DtAcervoInfo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.Processo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.NuAdvogado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.AreaJud)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.GrupoAssunto)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.DtEntrada)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.VlrCausa)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.DtCausa)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.NuVara)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.NuForo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.DtFinalizado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_cadastro_finalizado>()
                .Property(e => e.Finalizado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_acervoFinalizado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_acervoFinalizado>()
                .Property(e => e.NuAdvogado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_acervoFinalizado>()
                .Property(e => e.IdTerceirizacao)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_acervoFinalizado>()
                .Property(e => e.IdRelevante)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_advogadoContraFinalizado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_advogadoContraFinalizado>()
                .Property(e => e.AdvogadoContra)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_advogadoContraFinalizado>()
                .Property(e => e.NuOAB)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_assuntoFinalizado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_assuntoFinalizado>()
                .Property(e => e.Assunto)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_CadContratoFinalizado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_CadContratoFinalizado>()
                .Property(e => e.NoParte)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_CadContratoFinalizado>()
                .Property(e => e.NuContrato)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_CadExpedienteVinculadoFinalizado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_CadExpedienteVinculadoFinalizado>()
                .Property(e => e.ExpedienteVinculado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_consultaRelevante>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_consultaRelevante>()
                .Property(e => e.ConsultaPortal)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_consultaRelevante>()
                .Property(e => e.DtFinalizado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_consultaRelevante>()
                .Property(e => e.Finalizado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.Processo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.Expr1002)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.NoParteJudicial)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.CondicaoParte)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.DtEntrada)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.NuAdvogado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.AreaJud)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.GrupoAssunto)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.VlrCausa)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.DtCausa)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.NuVara)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.NuForo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.Comarca)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.CentroCusto)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.UnidSubsidio)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.TpAcao)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.DtFinalizado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ExpedienteFinalizado>()
                .Property(e => e.Finalizado)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ParteJudicialFinalizado>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ParteJudicialFinalizado>()
                .Property(e => e.NoParteJudicial)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ParteJudicialFinalizado>()
                .Property(e => e.CpfCnpj)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ParteJudicialFinalizado>()
                .Property(e => e.CondicaoParte)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Exporta_ParteJudicialFinalizado>()
                .Property(e => e.Matricula)
                .IsUnicode(false);
        }
    }
}
