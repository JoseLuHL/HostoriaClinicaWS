using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HostoriaClinicaWS.Models
{
    public partial class HistoriaClinicaContext : DbContext
    {
        public HistoriaClinicaContext()
        {
        }

        public HistoriaClinicaContext(DbContextOptions<HistoriaClinicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccidenteLaboral> AccidenteLaboral { get; set; }
        public virtual DbSet<Antecedente> Antecedente { get; set; }
        public virtual DbSet<AntecedentePersonal> AntecedentePersonal { get; set; }
        public virtual DbSet<AntecednteFamiliar> AntecednteFamiliar { get; set; }
        public virtual DbSet<Arl> Arl { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<CicloMenstrual> CicloMenstrual { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Concepto> Concepto { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Diagnostico> Diagnostico { get; set; }
        public virtual DbSet<DiagnosticoPaciente> DiagnosticoPaciente { get; set; }
        public virtual DbSet<Dominancia> Dominancia { get; set; }
        public virtual DbSet<Edad> Edad { get; set; }
        public virtual DbSet<Elemento> Elemento { get; set; }
        public virtual DbSet<ElementoProteccion> ElementoProteccion { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Enfasis> Enfasis { get; set; }
        public virtual DbSet<Enfermedad> Enfermedad { get; set; }
        public virtual DbSet<EnfermedadProfesional> EnfermedadProfesional { get; set; }
        public virtual DbSet<EntradaHistoria> EntradaHistoria { get; set; }
        public virtual DbSet<EntradaProvisional> EntradaProvisional { get; set; }
        public virtual DbSet<Eps> Eps { get; set; }
        public virtual DbSet<EquilibrioDes> EquilibrioDes { get; set; }
        public virtual DbSet<Equilibro> Equilibro { get; set; }
        public virtual DbSet<EquilibroPaciente> EquilibroPaciente { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<EstadoEquilibrioPaciente> EstadoEquilibrioPaciente { get; set; }
        public virtual DbSet<Examen> Examen { get; set; }
        public virtual DbSet<ExamenFisico> ExamenFisico { get; set; }
        public virtual DbSet<ExamenFisico1> ExamenFisico1 { get; set; }
        public virtual DbSet<ExamenLaboratorio> ExamenLaboratorio { get; set; }
        public virtual DbSet<ExamenPaciente> ExamenPaciente { get; set; }
        public virtual DbSet<ExamenPracticado> ExamenPracticado { get; set; }
        public virtual DbSet<ExamenPracticadoProvi> ExamenPracticadoProvi { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Habito> Habito { get; set; }
        public virtual DbSet<HabitoPaciente> HabitoPaciente { get; set; }
        public virtual DbSet<InformacionOcupacional> InformacionOcupacional { get; set; }
        public virtual DbSet<InformacionOcupacionalProvi> InformacionOcupacionalProvi { get; set; }
        public virtual DbSet<Inmunizar> Inmunizar { get; set; }
        public virtual DbSet<ItemActivar> ItemActivar { get; set; }
        public virtual DbSet<Medico> Medico { get; set; }
        public virtual DbSet<ModulosUsuario> ModulosUsuario { get; set; }
        public virtual DbSet<NivelEducativo> NivelEducativo { get; set; }
        public virtual DbSet<Ocupacion> Ocupacion { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<ParteAfectada> ParteAfectada { get; set; }
        public virtual DbSet<Probabilidad> Probabilidad { get; set; }
        public virtual DbSet<ProbabilidadRiego> ProbabilidadRiego { get; set; }
        public virtual DbSet<Profesion> Profesion { get; set; }
        public virtual DbSet<Recomendacion> Recomendacion { get; set; }
        public virtual DbSet<RecomendacionDescripcion> RecomendacionDescripcion { get; set; }
        public virtual DbSet<RecomendacionPaciente> RecomendacionPaciente { get; set; }
        public virtual DbSet<Revision> Revision { get; set; }
        public virtual DbSet<RevisionSistema> RevisionSistema { get; set; }
        public virtual DbSet<Riesgo> Riesgo { get; set; }
        public virtual DbSet<RiesgoOcupacional> RiesgoOcupacional { get; set; }
        public virtual DbSet<SiNo> SiNo { get; set; }
        public virtual DbSet<Sistema> Sistema { get; set; }
        public virtual DbSet<TempoFumadores> TempoFumadores { get; set; }
        public virtual DbSet<TipResultado> TipResultado { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoExamen> TipoExamen { get; set; }
        public virtual DbSet<TipoExamenEnfasis> TipoExamenEnfasis { get; set; }
        public virtual DbSet<TipoExamenLaboratorio> TipoExamenLaboratorio { get; set; }
        public virtual DbSet<TipoInmunizacion> TipoInmunizacion { get; set; }
        public virtual DbSet<TipoRiesgo> TipoRiesgo { get; set; }
        public virtual DbSet<TipoSangre> TipoSangre { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioModulo> UsuarioModulo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccidenteLaboral>(entity =>
            {
                entity.HasKey(e => new { e.AccLabCodigo, e.AccLabEntradaNumero });

                entity.Property(e => e.AccLabCodigo)
                    .HasColumnName("AccLab_Codigo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccLabEntradaNumero).HasColumnName("AccLab_Entrada_Numero");

                entity.Property(e => e.AccLabDiasIncapacidad)
                    .HasColumnName("AccLab_DiasIncapacidad")
                    .HasMaxLength(50);

                entity.Property(e => e.AccLabEmpresa)
                    .IsRequired()
                    .HasColumnName("AccLab_Empresa")
                    .HasMaxLength(60);

                entity.Property(e => e.AccLabFecha)
                    .HasColumnName("AccLab_Fecha")
                    .HasColumnType("date");

                entity.Property(e => e.AccLabNaturaleza)
                    .HasColumnName("AccLab_Naturaleza")
                    .HasMaxLength(50);

                entity.Property(e => e.AccLabParteAfectadaCodigo).HasColumnName("AccLab_ParteAfectada_Codigo");

                entity.Property(e => e.AccLabSecuela)
                    .HasColumnName("AccLab_Secuela")
                    .HasMaxLength(200);

                entity.HasOne(d => d.AccLabEntradaNumeroNavigation)
                    .WithMany(p => p.AccidenteLaboral)
                    .HasForeignKey(d => d.AccLabEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccidenteLaboral_EntradaHistoria");

                entity.HasOne(d => d.AccLabParteAfectadaCodigoNavigation)
                    .WithMany(p => p.AccidenteLaboral)
                    .HasForeignKey(d => d.AccLabParteAfectadaCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccidenteLaboral_ParteAfectada");
            });

            modelBuilder.Entity<Antecedente>(entity =>
            {
                entity.HasKey(e => e.AntCodigo);

                entity.Property(e => e.AntCodigo).HasColumnName("Ant_Codigo");

                entity.Property(e => e.AntDescripcion)
                    .IsRequired()
                    .HasColumnName("Ant_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AntecedentePersonal>(entity =>
            {
                entity.HasKey(e => e.AntPerNumero);

                entity.Property(e => e.AntPerNumero).HasColumnName("AntPer_Numero");

                entity.Property(e => e.AntPerAntecedendeCodigo).HasColumnName("AntPer_Antecedende_Codigo");

                entity.Property(e => e.AntPerDiagnostico)
                    .IsRequired()
                    .HasColumnName("AntPer_Diagnostico")
                    .HasMaxLength(500);

                entity.Property(e => e.AntPerEntradaNumero).HasColumnName("AntPer_Entrada_Numero");

                entity.Property(e => e.AntPerObservacion)
                    .HasColumnName("AntPer_Observacion")
                    .HasMaxLength(50);

                entity.HasOne(d => d.AntPerAntecedendeCodigoNavigation)
                    .WithMany(p => p.AntecedentePersonal)
                    .HasForeignKey(d => d.AntPerAntecedendeCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AntecedentePersonal_Antecedente");

                entity.HasOne(d => d.AntPerEntradaNumeroNavigation)
                    .WithMany(p => p.AntecedentePersonal)
                    .HasForeignKey(d => d.AntPerEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AntecedentePersonal_EntradaHistoria");
            });

            modelBuilder.Entity<AntecednteFamiliar>(entity =>
            {
                entity.HasKey(e => e.AntFamNumero);

                entity.Property(e => e.AntFamNumero).HasColumnName("AntFam_Numero");

                entity.Property(e => e.AntFamEnfermedadCodigo)
                    .IsRequired()
                    .HasColumnName("AntFam_Enfermedad_Codigo")
                    .HasMaxLength(500);

                entity.Property(e => e.AntFamEntradaNumero).HasColumnName("AntFam_Entrada_Numero");

                entity.Property(e => e.AntFamMortalidad).HasColumnName("AntFam_Mortalidad");

                entity.Property(e => e.AntFamParentesco)
                    .IsRequired()
                    .HasColumnName("AntFam_Parentesco")
                    .HasMaxLength(50);

                entity.HasOne(d => d.AntFamEntradaNumeroNavigation)
                    .WithMany(p => p.AntecednteFamiliar)
                    .HasForeignKey(d => d.AntFamEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AntecednteFamiliar_EntradaHistoria");
            });

            modelBuilder.Entity<Arl>(entity =>
            {
                entity.HasKey(e => e.ArlCodigo);

                entity.ToTable("ARL");

                entity.Property(e => e.ArlCodigo).HasColumnName("Arl_Codigo");

                entity.Property(e => e.ArlDescripcion)
                    .IsRequired()
                    .HasColumnName("Arl_Descripcion")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.CargCodigo);

                entity.Property(e => e.CargCodigo).HasColumnName("Carg_Codigo");

                entity.Property(e => e.CargDescripcion)
                    .IsRequired()
                    .HasColumnName("Carg_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CicloMenstrual>(entity =>
            {
                entity.HasKey(e => e.CicMensEntradaNumero);

                entity.Property(e => e.CicMensEntradaNumero)
                    .HasColumnName("CicMens_Entrada_Numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.CicMensAbortos)
                    .IsRequired()
                    .HasColumnName("CicMens_Abortos")
                    .HasMaxLength(50);

                entity.Property(e => e.CicMensEdadmenarca)
                    .HasColumnName("CicMens_Edadmenarca")
                    .HasMaxLength(10);

                entity.Property(e => e.CicMensEdadmenopausia)
                    .HasColumnName("CicMens_Edadmenopausia")
                    .HasMaxLength(10);

                entity.Property(e => e.CicMensFechaUltimaRegla)
                    .HasColumnName("CicMens_FechaUltimaRegla")
                    .HasColumnType("date");

                entity.Property(e => e.CicMensGestaciones)
                    .IsRequired()
                    .HasColumnName("CicMens_Gestaciones")
                    .HasMaxLength(50);

                entity.Property(e => e.CicMensHijos)
                    .HasColumnName("CicMens_Hijos")
                    .HasMaxLength(50);

                entity.Property(e => e.CicMensHijosSanos).HasColumnName("CicMens_HijosSanos");

                entity.Property(e => e.CicMensMetodo)
                    .HasColumnName("CicMens_metodo")
                    .HasMaxLength(10);

                entity.Property(e => e.CicMensPartos)
                    .IsRequired()
                    .HasColumnName("CicMens_Partos")
                    .HasMaxLength(50);

                entity.Property(e => e.CicMensPlanificacion).HasColumnName("CicMens_Planificacion");

                entity.Property(e => e.CicMensResultadoCitologia)
                    .HasColumnName("CicMens_ResultadoCitologia")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CicMensEntradaNumeroNavigation)
                    .WithOne(p => p.CicloMenstrual)
                    .HasForeignKey<CicloMenstrual>(d => d.CicMensEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CicloMenstrual_EntradaHistoria");
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.HasKey(e => new { e.CiudCodDepto, e.CiudCodigo })
                    .HasName("PK_Table1");

                entity.Property(e => e.CiudCodDepto)
                    .HasColumnName("Ciud_CodDepto")
                    .HasMaxLength(2);

                entity.Property(e => e.CiudCodigo)
                    .HasColumnName("Ciud_Codigo")
                    .HasMaxLength(3);

                entity.Property(e => e.CiudNombre)
                    .IsRequired()
                    .HasColumnName("Ciud_Nombre")
                    .HasMaxLength(25);

                entity.HasOne(d => d.CiudCodDeptoNavigation)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.CiudCodDepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ciudad_Departamento");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CliIdentificacion);

                entity.Property(e => e.CliIdentificacion)
                    .HasColumnName("Cli_Identificacion")
                    .HasMaxLength(10);

                entity.Property(e => e.CliApellido1)
                    .IsRequired()
                    .HasColumnName("Cli_Apellido1")
                    .HasMaxLength(20);

                entity.Property(e => e.CliApellido2)
                    .HasColumnName("Cli_Apellido2")
                    .HasMaxLength(20);

                entity.Property(e => e.CliCodCiudad)
                    .IsRequired()
                    .HasColumnName("Cli_CodCiudad")
                    .HasMaxLength(3);

                entity.Property(e => e.CliCodDepto)
                    .IsRequired()
                    .HasColumnName("Cli_CodDepto")
                    .HasMaxLength(2);

                entity.Property(e => e.CliCodGenero)
                    .IsRequired()
                    .HasColumnName("Cli_CodGenero")
                    .HasMaxLength(1);

                entity.Property(e => e.CliCodLista).HasColumnName("Cli_CodLista");

                entity.Property(e => e.CliCodNivelEducativo).HasColumnName("Cli_CodNivelEducativo");

                entity.Property(e => e.CliCodProfesion)
                    .IsRequired()
                    .HasColumnName("Cli_CodProfesion")
                    .HasMaxLength(4);

                entity.Property(e => e.CliDireccion)
                    .HasColumnName("Cli_Direccion")
                    .HasMaxLength(50);

                entity.Property(e => e.CliDominanciaCodigo).HasColumnName("Cli_Dominancia_Codigo");

                entity.Property(e => e.CliEstadoCivil).HasColumnName("Cli_EstadoCivil");

                entity.Property(e => e.CliFecha)
                    .HasColumnName("Cli_Fecha")
                    .HasColumnType("date");

                entity.Property(e => e.CliFechaNacimiento)
                    .HasColumnName("Cli_FechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.CliFirma)
                    .HasColumnName("Cli_Firma")
                    .HasColumnType("image");

                entity.Property(e => e.CliFoto)
                    .HasColumnName("Cli_Foto")
                    .HasColumnType("image");

                entity.Property(e => e.CliHuella)
                    .HasColumnName("Cli_Huella")
                    .HasColumnType("image");

                entity.Property(e => e.CliNombre1)
                    .IsRequired()
                    .HasColumnName("Cli_Nombre1")
                    .HasMaxLength(20);

                entity.Property(e => e.CliNombre2)
                    .HasColumnName("Cli_Nombre2")
                    .HasMaxLength(20);

                entity.Property(e => e.CliTelefono)
                    .HasColumnName("Cli_Telefono")
                    .HasMaxLength(12);

                entity.Property(e => e.CliTipoIdentificacion)
                    .IsRequired()
                    .HasColumnName("Cli_TipoIdentificacion")
                    .HasMaxLength(3);

                entity.Property(e => e.CliTipoSangre).HasColumnName("Cli_TipoSangre");
            });

            modelBuilder.Entity<Concepto>(entity =>
            {
                entity.HasKey(e => e.ConcCodigo);

                entity.Property(e => e.ConcCodigo).HasColumnName("Conc_Codigo");

                entity.Property(e => e.ConcDescripcion)
                    .IsRequired()
                    .HasColumnName("Conc_Descripcion")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.DeptCodigo);

                entity.Property(e => e.DeptCodigo)
                    .HasColumnName("Dept_Codigo")
                    .HasMaxLength(2);

                entity.Property(e => e.DeptNombre)
                    .IsRequired()
                    .HasColumnName("Dept_Nombre")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Diagnostico>(entity =>
            {
                entity.HasKey(e => e.DiagId);

                entity.HasIndex(e => e.DiagCodigo)
                    .HasName("UQ_CodDiagnostico")
                    .IsUnique();

                entity.Property(e => e.DiagId).HasColumnName("Diag_Id");

                entity.Property(e => e.DiagCodigo)
                    .IsRequired()
                    .HasColumnName("Diag_Codigo")
                    .HasMaxLength(5);

                entity.Property(e => e.DiagDescripcion)
                    .IsRequired()
                    .HasColumnName("Diag_Descripcion")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<DiagnosticoPaciente>(entity =>
            {
                entity.HasKey(e => new { e.DiagPaciNumeroHistoria, e.DiagPaciCodDiagnostico });

                entity.Property(e => e.DiagPaciNumeroHistoria).HasColumnName("DiagPaci_NumeroHistoria");

                entity.Property(e => e.DiagPaciCodDiagnostico)
                    .HasColumnName("DiagPaci_CodDiagnostico")
                    .HasMaxLength(5);

                entity.HasOne(d => d.DiagPaciCodDiagnosticoNavigation)
                    .WithMany(p => p.DiagnosticoPaciente)
                    .HasPrincipalKey(p => p.DiagCodigo)
                    .HasForeignKey(d => d.DiagPaciCodDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiagnosticoPaciente_Diagnostico");

                entity.HasOne(d => d.DiagPaciNumeroHistoriaNavigation)
                    .WithMany(p => p.DiagnosticoPaciente)
                    .HasForeignKey(d => d.DiagPaciNumeroHistoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiagnosticoPaciente_EntradaHistoria");
            });

            modelBuilder.Entity<Dominancia>(entity =>
            {
                entity.HasKey(e => e.DomCodigo);

                entity.Property(e => e.DomCodigo).HasColumnName("Dom_Codigo");

                entity.Property(e => e.DomDescripcion)
                    .IsRequired()
                    .HasColumnName("Dom_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Edad>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EdadAño).HasColumnName("Edad_Año");

                entity.Property(e => e.EdadGrupoEtario)
                    .HasColumnName("Edad_GrupoEtario")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Elemento>(entity =>
            {
                entity.HasKey(e => e.ElemCodigo);

                entity.Property(e => e.ElemCodigo).HasColumnName("Elem_Codigo");

                entity.Property(e => e.ElemDescripcion)
                    .IsRequired()
                    .HasColumnName("Elem_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ElementoProteccion>(entity =>
            {
                entity.HasKey(e => new { e.EleProtElementoCodigo, e.EleProtInformacionOcupacionalNumero });

                entity.Property(e => e.EleProtElementoCodigo).HasColumnName("EleProt_Elemento_Codigo");

                entity.Property(e => e.EleProtInformacionOcupacionalNumero).HasColumnName("EleProt_InformacionOcupacional_Numero");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.EmprCodigo);

                entity.HasIndex(e => e.EmpreNit)
                    .HasName("nitun")
                    .IsUnique();

                entity.Property(e => e.EmprCodigo).HasColumnName("Empr_Codigo");

                entity.Property(e => e.EmpreNit)
                    .IsRequired()
                    .HasColumnName("Empre_Nit")
                    .HasMaxLength(15);

                entity.Property(e => e.EmpreRazonSocial)
                    .IsRequired()
                    .HasColumnName("Empre_RazonSocial")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Enfasis>(entity =>
            {
                entity.HasKey(e => e.EnfaCodigo);

                entity.Property(e => e.EnfaCodigo).HasColumnName("Enfa_Codigo");

                entity.Property(e => e.EnfaDescripcion)
                    .IsRequired()
                    .HasColumnName("Enfa_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Enfermedad>(entity =>
            {
                entity.HasKey(e => e.EnfCodigo);

                entity.Property(e => e.EnfCodigo).HasColumnName("Enf_Codigo");

                entity.Property(e => e.EnfDescipcion)
                    .IsRequired()
                    .HasColumnName("Enf_Descipcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EnfermedadProfesional>(entity =>
            {
                entity.HasKey(e => new { e.EnfProEnfermedadCodigo, e.EnfProEntradaNumero, e.EnfProCodigo });

                entity.Property(e => e.EnfProEnfermedadCodigo).HasColumnName("EnfPro_Enfermedad_Codigo");

                entity.Property(e => e.EnfProEntradaNumero).HasColumnName("EnfPro_Entrada_Numero");

                entity.Property(e => e.EnfProCodigo)
                    .HasColumnName("EnfPro_Codigo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EnfProEmpresa)
                    .IsRequired()
                    .HasColumnName("EnfPro_Empresa")
                    .HasMaxLength(50);

                entity.Property(e => e.EnfProFechaDiagnostico)
                    .HasColumnName("EnfPro_FechaDiagnostico")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<EntradaHistoria>(entity =>
            {
                entity.HasKey(e => e.EntrNumero);

                entity.Property(e => e.EntrNumero).HasColumnName("Entr_Numero");

                entity.Property(e => e.EntCodArl).HasColumnName("Ent_CodARL");

                entity.Property(e => e.EntCodEps).HasColumnName("Ent_CodEPS");

                entity.Property(e => e.EntConceptoAptitud)
                    .HasColumnName("Ent_conceptoAptitud")
                    .HasMaxLength(256);

                entity.Property(e => e.EntEnfasis).HasColumnName("Ent_Enfasis");

                entity.Property(e => e.EntEstado).HasColumnName("Ent_Estado");

                entity.Property(e => e.EntMedico)
                    .HasColumnName("Ent_Medico")
                    .HasMaxLength(10);

                entity.Property(e => e.EntrConceptoCodigo).HasColumnName("Entr_Concepto_Codigo");

                entity.Property(e => e.EntrDiagnostico)
                    .IsRequired()
                    .HasColumnName("Entr_Diagnostico")
                    .HasMaxLength(5);

                entity.Property(e => e.EntrFechaEntrada)
                    .HasColumnName("Entr_FechaEntrada")
                    .HasColumnType("date");

                entity.Property(e => e.EntrIdPaciente)
                    .IsRequired()
                    .HasColumnName("Entr_IdPaciente")
                    .HasMaxLength(10);

                entity.Property(e => e.EntrRecomendacion)
                    .HasColumnName("Entr_Recomendacion")
                    .HasMaxLength(200);

                entity.Property(e => e.EntrReubicacion).HasColumnName("Entr_Reubicacion");

                entity.Property(e => e.EntrTipoExamenCodigo).HasColumnName("Entr_TipoExamenCodigo");

                entity.HasOne(d => d.EntMedicoNavigation)
                    .WithMany(p => p.EntradaHistoria)
                    .HasForeignKey(d => d.EntMedico)
                    .HasConstraintName("FK_EntradaHistoria_Medico");

                //entity.HasOne(d => d.EntrIdPacienteNavigation)
                //    .WithMany(p => p.EntradaHistoria)
                //    .HasForeignKey(d => d.EntrIdPaciente)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_EntradaHistoria_Paciente");
            });

            modelBuilder.Entity<EntradaProvisional>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EntCodigo)
                    .HasColumnName("Ent_Codigo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EntEnfasis).HasColumnName("Ent_Enfasis");

                entity.Property(e => e.EntEstado).HasColumnName("Ent_Estado");

                entity.Property(e => e.EntrConceptoCodigo).HasColumnName("Entr_Concepto_Codigo");

                entity.Property(e => e.EntrFechaEntrada)
                    .IsRequired()
                    .HasColumnName("Entr_FechaEntrada")
                    .HasMaxLength(50);

                entity.Property(e => e.EntrIdPaciente)
                    .IsRequired()
                    .HasColumnName("Entr_IdPaciente")
                    .HasMaxLength(10);

                entity.Property(e => e.EntrTipoExamenCodigo).HasColumnName("Entr_TipoExamenCodigo");

                entity.HasOne(d => d.EntEnfasisNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.EntEnfasis)
                    .HasConstraintName("FK_EntradaHistoria_TipoExamenEnfasispro");

                entity.HasOne(d => d.EntrIdPacienteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.EntrIdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntradaHistoria_pro");

                entity.HasOne(d => d.EntrTipoExamenCodigoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.EntrTipoExamenCodigo)
                    .HasConstraintName("FK_EntradaHistoria_Tipopro");
            });

            modelBuilder.Entity<Eps>(entity =>
            {
                entity.HasKey(e => e.EpsCodigo);

                entity.ToTable("EPS");

                entity.Property(e => e.EpsCodigo).HasColumnName("Eps_Codigo");

                entity.Property(e => e.EpsDescripcion)
                    .IsRequired()
                    .HasColumnName("Eps_Descripcion")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<EquilibrioDes>(entity =>
            {
                entity.HasKey(e => e.EqDesCodigo);

                entity.Property(e => e.EqDesCodigo).HasColumnName("EqDes_Codigo");

                entity.Property(e => e.EqDesDescripcion)
                    .IsRequired()
                    .HasColumnName("EqDes_Descripcion")
                    .HasMaxLength(50);

                entity.Property(e => e.EqDesEqilibrio).HasColumnName("EqDes_Eqilibrio");

                entity.HasOne(d => d.EqDesEqilibrioNavigation)
                    .WithMany(p => p.EquilibrioDes)
                    .HasForeignKey(d => d.EqDesEqilibrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquilibrioDes_Equilibro");
            });

            modelBuilder.Entity<Equilibro>(entity =>
            {
                entity.HasKey(e => e.EquiCodigo);

                entity.Property(e => e.EquiCodigo).HasColumnName("Equi_Codigo");

                entity.Property(e => e.EquiDescripcion)
                    .HasColumnName("Equi_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EquilibroPaciente>(entity =>
            {
                entity.HasKey(e => e.EqiPaCidigo);

                entity.Property(e => e.EqiPaCidigo).HasColumnName("EqiPa_Cidigo");

                entity.Property(e => e.EqiPaEquilibro).HasColumnName("EqiPa_Equilibro");

                entity.Property(e => e.EqiPaEstado).HasColumnName("EqiPa_Estado");

                entity.Property(e => e.EqiPaHistoriaNumero).HasColumnName("EqiPa_HistoriaNumero");

                entity.Property(e => e.EqiPaMarcha)
                    .HasColumnName("EqiPa_Marcha")
                    .HasMaxLength(500);

                entity.Property(e => e.EqiPaPiel)
                    .HasColumnName("EqiPa_Piel")
                    .HasMaxLength(500);

                entity.Property(e => e.EqiPaReflejos)
                    .HasColumnName("EqiPa_Reflejos")
                    .HasMaxLength(500);

                entity.HasOne(d => d.EqiPaEquilibroNavigation)
                    .WithMany(p => p.EquilibroPaciente)
                    .HasForeignKey(d => d.EqiPaEquilibro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquilibroPaciente_EquilibrioDes");

                entity.HasOne(d => d.EqiPaEstadoNavigation)
                    .WithMany(p => p.EquilibroPaciente)
                    .HasForeignKey(d => d.EqiPaEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquilibroPaciente_EstadoEquilibrioPaciente");
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.HasKey(e => e.EstCivilCodigo);

                entity.Property(e => e.EstCivilCodigo).HasColumnName("EstCivil_Codigo");

                entity.Property(e => e.EstCivilDescripcion)
                    .IsRequired()
                    .HasColumnName("EstCivil_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EstadoEquilibrioPaciente>(entity =>
            {
                entity.HasKey(e => e.EsEquiCodigo);

                entity.Property(e => e.EsEquiCodigo).HasColumnName("EsEqui_Codigo");

                entity.Property(e => e.EsEquiDescripcion)
                    .IsRequired()
                    .HasColumnName("EsEqui_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Examen>(entity =>
            {
                entity.HasKey(e => e.ExamCodigo);

                entity.Property(e => e.ExamCodigo).HasColumnName("Exam_Codigo");

                entity.Property(e => e.ExamDescripcion)
                    .IsRequired()
                    .HasColumnName("Exam_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ExamenFisico>(entity =>
            {
                entity.HasKey(e => e.ExFiCodigo);

                entity.ToTable("Examen_Fisico");

                entity.Property(e => e.ExFiCodigo).HasColumnName("ExFi_Codigo");

                entity.Property(e => e.ExFiDescripcion)
                    .IsRequired()
                    .HasColumnName("ExFi_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ExamenFisico1>(entity =>
            {
                entity.HasKey(e => e.ExaFisiEntradaNumero);

                entity.ToTable("ExamenFisico");

                entity.Property(e => e.ExaFisiEntradaNumero)
                    .HasColumnName("ExaFisi_Entrada_Numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExaFisiFrecuenciaCardiaca)
                    .HasColumnName("ExaFisi_FrecuenciaCardiaca")
                    .HasMaxLength(50);

                entity.Property(e => e.ExaFisiImc)
                    .HasColumnName("ExaFisi_IMC")
                    .HasMaxLength(50);

                entity.Property(e => e.ExaFisiInterpretacion)
                    .HasColumnName("ExaFisi_Interpretacion")
                    .HasMaxLength(50);

                entity.Property(e => e.ExaFisiLateracidad)
                    .HasColumnName("ExaFisi_Lateracidad")
                    .HasMaxLength(50);

                entity.Property(e => e.ExaFisiPerimetroCintura)
                    .HasColumnName("ExaFisi_PerimetroCintura")
                    .HasMaxLength(50);

                entity.Property(e => e.ExaFisiPeso)
                    .HasColumnName("ExaFisi_Peso")
                    .HasMaxLength(50);

                entity.Property(e => e.ExaFisiPresionArterial)
                    .HasColumnName("ExaFisi_PresionArterial")
                    .HasMaxLength(50);

                entity.Property(e => e.ExaFisiTalla)
                    .HasColumnName("ExaFisi_Talla")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ExaFisiEntradaNumeroNavigation)
                    .WithOne(p => p.ExamenFisico1)
                    .HasForeignKey<ExamenFisico1>(d => d.ExaFisiEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamenFisico_EntradaHistoria");
            });

            modelBuilder.Entity<ExamenLaboratorio>(entity =>
            {
                entity.HasKey(e => new { e.ExaLaboEntradaNumero, e.ExaLaboExamenCodigo });

                entity.Property(e => e.ExaLaboEntradaNumero).HasColumnName("ExaLabo_Entrada_Numero");

                entity.Property(e => e.ExaLaboExamenCodigo).HasColumnName("ExaLabo_ExamenCodigo");

                entity.HasOne(d => d.ExaLaboEntradaNumeroNavigation)
                    .WithMany(p => p.ExamenLaboratorio)
                    .HasForeignKey(d => d.ExaLaboEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamenLaboratorio_EntradaHistoria");

                entity.HasOne(d => d.ExaLaboExamenCodigoNavigation)
                    .WithMany(p => p.ExamenLaboratorio)
                    .HasForeignKey(d => d.ExaLaboExamenCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamenLaboratorio_TipoExamenLaboratorio");
            });

            modelBuilder.Entity<ExamenPaciente>(entity =>
            {
                entity.HasKey(e => e.ExamPaciCodigo);

                entity.ToTable("Examen_Paciente");

                entity.Property(e => e.ExamPaciCodigo).HasColumnName("ExamPaci_Codigo");

                entity.Property(e => e.ExamPaciEstado).HasColumnName("ExamPaci_Estado");

                entity.Property(e => e.ExamPaciExamenCodigo).HasColumnName("ExamPaci_Examen_Codigo");

                entity.Property(e => e.ExamPaciNumeroEntrada).HasColumnName("ExamPaci_Numero_Entrada");

                entity.Property(e => e.ExamPaciObservacion)
                    .HasColumnName("ExamPaci_Observacion")
                    .HasMaxLength(400);

                entity.HasOne(d => d.ExamPaciExamenCodigoNavigation)
                    .WithMany(p => p.ExamenPaciente)
                    .HasForeignKey(d => d.ExamPaciExamenCodigo)
                    .HasConstraintName("FK_Examen_Paciente_Examen_Fisico");

                entity.HasOne(d => d.ExamPaciNumeroEntradaNavigation)
                    .WithMany(p => p.ExamenPaciente)
                    .HasForeignKey(d => d.ExamPaciNumeroEntrada)
                    .HasConstraintName("FK_Examen_Paciente_EntradaHistoria");
            });

            modelBuilder.Entity<ExamenPracticado>(entity =>
            {
                entity.HasKey(e => new { e.ExaPracExamenCodigo, e.ExaPracEntradaNumero, e.ExaPracCodigo });

                entity.Property(e => e.ExaPracExamenCodigo).HasColumnName("ExaPrac_Examen_Codigo");

                entity.Property(e => e.ExaPracEntradaNumero).HasColumnName("ExaPrac_Entrada_Numero");

                entity.Property(e => e.ExaPracCodigo)
                    .HasColumnName("ExaPrac_Codigo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExaPracAjuntar)
                    .HasColumnName("ExaPrac_Ajuntar")
                    .HasColumnType("image");

                entity.Property(e => e.ExaPracFechaExamen)
                    .HasColumnName("ExaPrac_FechaExamen")
                    .HasColumnType("date");

                entity.Property(e => e.ExaPracResultado).HasColumnName("ExaPrac_Resultado");

                entity.HasOne(d => d.ExaPracEntradaNumeroNavigation)
                    .WithMany(p => p.ExamenPracticado)
                    .HasForeignKey(d => d.ExaPracEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamenPracticado_EntradaHistoria");

                entity.HasOne(d => d.ExaPracExamenCodigoNavigation)
                    .WithMany(p => p.ExamenPracticado)
                    .HasForeignKey(d => d.ExaPracExamenCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamenPracticado_Examen");

                entity.HasOne(d => d.ExaPracResultadoNavigation)
                    .WithMany(p => p.ExamenPracticado)
                    .HasForeignKey(d => d.ExaPracResultado)
                    .HasConstraintName("FK_ExamenPracticado_TipResultado");
            });

            modelBuilder.Entity<ExamenPracticadoProvi>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ExaPacPaciente)
                    .HasColumnName("ExaPac_Paciente")
                    .HasMaxLength(10);

                entity.Property(e => e.ExaPracAjuntar)
                    .HasColumnName("ExaPrac_Ajuntar")
                    .HasColumnType("image");

                entity.Property(e => e.ExaPracExamenCodigo).HasColumnName("ExaPrac_Examen_Codigo");

                entity.Property(e => e.ExaPracFechaExamen)
                    .HasColumnName("ExaPrac_FechaExamen")
                    .HasColumnType("date");

                entity.Property(e => e.ExaPracResultado).HasColumnName("ExaPrac_Resultado");

                entity.HasOne(d => d.ExaPracExamenCodigoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ExaPracExamenCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamenPracticado_Examenpro");

                entity.HasOne(d => d.ExaPracResultadoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ExaPracResultado)
                    .HasConstraintName("FK_ExamenPracticado_TipResultadopro");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.GenCodigo);

                entity.Property(e => e.GenCodigo)
                    .HasColumnName("Gen_Codigo")
                    .HasMaxLength(1);

                entity.Property(e => e.GenDescripcion)
                    .IsRequired()
                    .HasColumnName("Gen_Descripcion")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Habito>(entity =>
            {
                entity.HasKey(e => e.HabCodigo);

                entity.Property(e => e.HabCodigo).HasColumnName("Hab_Codigo");

                entity.Property(e => e.HabDescripcion)
                    .IsRequired()
                    .HasColumnName("Hab_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HabitoPaciente>(entity =>
            {
                entity.HasKey(e => new { e.HabPacEntradaNumero, e.HabPacHabitoCodigo });

                entity.Property(e => e.HabPacEntradaNumero).HasColumnName("HabPac_Entrada_Numero");

                entity.Property(e => e.HabPacHabitoCodigo).HasColumnName("HabPac_Habito_Codigo");

                entity.Property(e => e.HabPacCaracteristica)
                    .HasColumnName("HabPac_Caracteristica")
                    .HasMaxLength(50);

                entity.Property(e => e.HabPacFrecuencia)
                    .HasColumnName("HabPac_Frecuencia")
                    .HasMaxLength(50);

                entity.Property(e => e.HabPacObservacion)
                    .HasColumnName("HabPac_Observacion")
                    .HasMaxLength(50);

                entity.Property(e => e.HabPacTiempo)
                    .HasColumnName("HabPac_Tiempo")
                    .HasMaxLength(50);

                entity.HasOne(d => d.HabPacEntradaNumeroNavigation)
                    .WithMany(p => p.HabitoPaciente)
                    .HasForeignKey(d => d.HabPacEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HabitoPaciente_EntradaHistoria");

                entity.HasOne(d => d.HabPacHabitoCodigoNavigation)
                    .WithMany(p => p.HabitoPaciente)
                    .HasForeignKey(d => d.HabPacHabitoCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HabitoPaciente_Habito");
            });

            modelBuilder.Entity<InformacionOcupacional>(entity =>
            {
                entity.HasKey(e => e.InfOcuEntradaNumero)
                    .HasName("PK_InformacionOcupacional_1");

                entity.Property(e => e.InfOcuEntradaNumero)
                    .HasColumnName("InfOcu_Entrada_Numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.InfOcuArea)
                    .HasColumnName("InfOcu_Area")
                    .HasMaxLength(50);

                entity.Property(e => e.InfOcuCodEmpresa).HasColumnName("InfOcu_CodEmpresa");

                entity.Property(e => e.InfOcuCodOcupacion).HasColumnName("InfOcu_CodOcupacion");

                entity.Property(e => e.InfOcuDescripcionFunciones)
                    .HasColumnName("InfOcu_DescripcionFunciones")
                    .HasMaxLength(50);

                entity.Property(e => e.InfOcuElementoProte)
                    .HasColumnName("InfOcu_ElementoProte")
                    .HasMaxLength(200);

                entity.Property(e => e.InfOcuEmpresa)
                    .HasColumnName("InfOcu_Empresa")
                    .HasMaxLength(100);

                entity.Property(e => e.InfOcuFechaCargoActual)
                    .HasColumnName("InfOcu_FechaCargoActual")
                    .HasColumnType("date");

                entity.Property(e => e.InfOcuFechaIngreso)
                    .HasColumnName("InfOcu_FechaIngreso")
                    .HasColumnType("date");

                entity.Property(e => e.InfOcuHerramienta)
                    .HasColumnName("InfOcu_Herramienta")
                    .HasMaxLength(50);

                entity.Property(e => e.InfOcuJornada)
                    .IsRequired()
                    .HasColumnName("InfOcu_Jornada")
                    .HasMaxLength(50);

                entity.Property(e => e.InfOcuMaquinaria)
                    .HasColumnName("InfOcu_Maquinaria")
                    .HasMaxLength(50);

                entity.Property(e => e.InfOcuMateriaPrima)
                    .HasColumnName("InfOcu_MateriaPrima")
                    .HasMaxLength(50);

                entity.Property(e => e.InfOcuNumero)
                    .HasColumnName("InfOcu_Numero")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.InfOcuCodEmpresaNavigation)
                    .WithMany(p => p.InformacionOcupacional)
                    .HasForeignKey(d => d.InfOcuCodEmpresa)
                    .HasConstraintName("FK_InformacionOcupacional_Empresa");

                entity.HasOne(d => d.InfOcuCodOcupacionNavigation)
                    .WithMany(p => p.InformacionOcupacional)
                    .HasForeignKey(d => d.InfOcuCodOcupacion)
                    .HasConstraintName("FK_InformacionOcupacional_Cargo");

                entity.HasOne(d => d.InfOcuEntradaNumeroNavigation)
                    .WithOne(p => p.InformacionOcupacional)
                    .HasForeignKey<InformacionOcupacional>(d => d.InfOcuEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformacionOcupacional_EntradaHistoria");
            });

            modelBuilder.Entity<InformacionOcupacionalProvi>(entity =>
            {
                entity.HasKey(e => e.InfOcuNumero);

                entity.Property(e => e.InfOcuNumero).HasColumnName("InfOcu_Numero");

                entity.Property(e => e.InfOcuArea)
                    .HasColumnName("InfOcu_Area")
                    .HasMaxLength(50);

                entity.Property(e => e.InfOcuCodEmpresa).HasColumnName("InfOcu_CodEmpresa");

                entity.Property(e => e.InfOcuCodOcupacion)
                    .HasColumnName("InfOcu_CodOcupacion")
                    .HasMaxLength(50);

                entity.Property(e => e.InfOcuEmpresa)
                    .HasColumnName("InfOcu_Empresa")
                    .HasMaxLength(100);

                entity.Property(e => e.InfOcuFechaIngreso)
                    .HasColumnName("InfOcu_FechaIngreso")
                    .HasColumnType("date");

                entity.Property(e => e.InfOcuJornada)
                    .IsRequired()
                    .HasColumnName("InfOcu_Jornada")
                    .HasMaxLength(50);

                entity.Property(e => e.InfOcuPaciente)
                    .HasColumnName("InfOcu_paciente")
                    .HasMaxLength(12);

                entity.HasOne(d => d.InfOcuCodEmpresaNavigation)
                    .WithMany(p => p.InformacionOcupacionalProvi)
                    .HasForeignKey(d => d.InfOcuCodEmpresa)
                    .HasConstraintName("FK_InformacionOcupacionalProvi_Empresa");
            });

            modelBuilder.Entity<Inmunizar>(entity =>
            {
                entity.HasKey(e => new { e.InmuEntradaNumero, e.InmuTipoInmunizacionCodigo, e.InmuCodigo });

                entity.Property(e => e.InmuEntradaNumero).HasColumnName("Inmu_Entrada_Numero");

                entity.Property(e => e.InmuTipoInmunizacionCodigo).HasColumnName("Inmu_TipoInmunizacion_Codigo");

                entity.Property(e => e.InmuCodigo)
                    .HasColumnName("Inmu_Codigo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InmuDosis)
                    .HasColumnName("Inmu_Dosis")
                    .HasMaxLength(100);

                entity.Property(e => e.InmuFecha)
                    .HasColumnName("Inmu_Fecha")
                    .HasColumnType("date");

                entity.HasOne(d => d.InmuEntradaNumeroNavigation)
                    .WithMany(p => p.Inmunizar)
                    .HasForeignKey(d => d.InmuEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inmunizar_EntradaHistoria");

                entity.HasOne(d => d.InmuTipoInmunizacionCodigoNavigation)
                    .WithMany(p => p.Inmunizar)
                    .HasForeignKey(d => d.InmuTipoInmunizacionCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inmunizar_TipoInmunizacion");
            });

            modelBuilder.Entity<ItemActivar>(entity =>
            {
                entity.HasKey(e => e.IntemCodigo);

                entity.Property(e => e.IntemCodigo).HasColumnName("Intem_Codigo");

                entity.Property(e => e.IntemActivo).HasColumnName("Intem_Activo");

                entity.Property(e => e.IntemDescripcion)
                    .HasColumnName("Intem_Descripcion")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.HasKey(e => e.MedicIdentificacion);

                entity.Property(e => e.MedicIdentificacion)
                    .HasColumnName("Medic_Identificacion")
                    .HasMaxLength(10);

                entity.Property(e => e.MedicApellido1)
                    .IsRequired()
                    .HasColumnName("Medic_Apellido1")
                    .HasMaxLength(20);

                entity.Property(e => e.MedicApellido2)
                    .HasColumnName("Medic_Apellido2")
                    .HasMaxLength(20);

                entity.Property(e => e.MedicFirma)
                    .HasColumnName("Medic_Firma")
                    .HasColumnType("image");

                entity.Property(e => e.MedicFoto)
                    .HasColumnName("Medic_Foto")
                    .HasColumnType("image");

                entity.Property(e => e.MedicHuella)
                    .HasColumnName("Medic_Huella")
                    .HasColumnType("image");

                entity.Property(e => e.MedicNombre1)
                    .IsRequired()
                    .HasColumnName("Medic_Nombre1")
                    .HasMaxLength(20);

                entity.Property(e => e.MedicNombre2)
                    .HasColumnName("Medic_Nombre2")
                    .HasMaxLength(20);

                entity.Property(e => e.MedicTipoIdentificacion)
                    .IsRequired()
                    .HasColumnName("Medic_TipoIdentificacion")
                    .HasMaxLength(3);

                entity.HasOne(d => d.MedicIdentificacionNavigation)
                    .WithOne(p => p.Medico)
                    .HasForeignKey<Medico>(d => d.MedicIdentificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medico_Usuario");
            });

            modelBuilder.Entity<ModulosUsuario>(entity =>
            {
                entity.HasKey(e => e.ModCodigo);

                entity.Property(e => e.ModCodigo)
                    .HasColumnName("Mod_Codigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModDescripcion)
                    .IsRequired()
                    .HasColumnName("Mod_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NivelEducativo>(entity =>
            {
                entity.HasKey(e => e.NivEduCodigo);

                entity.Property(e => e.NivEduCodigo).HasColumnName("NivEdu_Codigo");

                entity.Property(e => e.NivEduDescripcion)
                    .HasColumnName("NivEdu_Descripcion")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Ocupacion>(entity =>
            {
                entity.HasKey(e => e.OcupCodigo);

                entity.Property(e => e.OcupCodigo).HasColumnName("Ocup_Codigo");

                entity.Property(e => e.OcupDescripcion)
                    .HasColumnName("Ocup_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.PacIdentificacion);

                entity.Property(e => e.PacIdentificacion)
                    .HasColumnName("Pac_Identificacion")
                    .HasMaxLength(10);

                entity.Property(e => e.PacApellido1)
                    .IsRequired()
                    .HasColumnName("Pac_Apellido1")
                    .HasMaxLength(20);

                entity.Property(e => e.PacApellido2)
                    .HasColumnName("Pac_Apellido2")
                    .HasMaxLength(20);

                entity.Property(e => e.PacCodArl).HasColumnName("Pac_CodARL");

                entity.Property(e => e.PacCodCiudad)
                    .IsRequired()
                    .HasColumnName("Pac_CodCiudad")
                    .HasMaxLength(3);

                entity.Property(e => e.PacCodDepto)
                    .IsRequired()
                    .HasColumnName("Pac_CodDepto")
                    .HasMaxLength(2);

                entity.Property(e => e.PacCodEps).HasColumnName("Pac_CodEPS");

                entity.Property(e => e.PacCodGenero)
                    .IsRequired()
                    .HasColumnName("Pac_CodGenero")
                    .HasMaxLength(1);

                entity.Property(e => e.PacCodNivelEducativo).HasColumnName("Pac_CodNivelEducativo");

                entity.Property(e => e.PacCodProfesion)
                    .IsRequired()
                    .HasColumnName("Pac_CodProfesion")
                    .HasMaxLength(4);

                entity.Property(e => e.PacDireccion)
                    .HasColumnName("Pac_Direccion")
                    .HasMaxLength(50);

                entity.Property(e => e.PacDominanciaCodigo).HasColumnName("Pac_Dominancia_Codigo");

                entity.Property(e => e.PacEstadoCivil).HasColumnName("Pac_EstadoCivil");

                entity.Property(e => e.PacFecha)
                    .HasColumnName("Pac_Fecha")
                    .HasColumnType("date");

                entity.Property(e => e.PacFechaNacimiento)
                    .HasColumnName("Pac_FechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.PacFirma)
                    .HasColumnName("Pac_Firma")
                    .HasColumnType("image");

                entity.Property(e => e.PacFoto)
                    .HasColumnName("Pac_Foto")
                    .HasColumnType("image");

                entity.Property(e => e.PacHuella)
                    .HasColumnName("Pac_Huella")
                    .HasColumnType("image");

                entity.Property(e => e.PacNombre1)
                    .IsRequired()
                    .HasColumnName("Pac_Nombre1")
                    .HasMaxLength(20);

                entity.Property(e => e.PacNombre2)
                    .HasColumnName("Pac_Nombre2")
                    .HasMaxLength(20);

                entity.Property(e => e.PacTelefono)
                    .HasColumnName("Pac_Telefono")
                    .HasMaxLength(12);

                entity.Property(e => e.PacTipoIdentificacion)
                    .IsRequired()
                    .HasColumnName("Pac_TipoIdentificacion")
                    .HasMaxLength(3);

                entity.Property(e => e.PacTipoSangre).HasColumnName("Pac_TipoSangre");

                entity.HasOne(d => d.PacCodArlNavigation)
                    .WithMany(p => p.Paciente)
                    .HasForeignKey(d => d.PacCodArl)
                    .HasConstraintName("FK_Paciente_ARL");

                entity.HasOne(d => d.PacCodEpsNavigation)
                    .WithMany(p => p.Paciente)
                    .HasForeignKey(d => d.PacCodEps)
                    .HasConstraintName("FK_Paciente_EPS");
            });

            modelBuilder.Entity<ParteAfectada>(entity =>
            {
                entity.HasKey(e => e.PartACodigo);

                entity.Property(e => e.PartACodigo).HasColumnName("PartA_Codigo");

                entity.Property(e => e.PartADescripcion)
                    .IsRequired()
                    .HasColumnName("PartA_Descripcion")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Probabilidad>(entity =>
            {
                entity.HasKey(e => e.ProbCodigo);

                entity.Property(e => e.ProbCodigo).HasColumnName("Prob_Codigo");

                entity.Property(e => e.ProbDescripcion)
                    .IsRequired()
                    .HasColumnName("Prob_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProbabilidadRiego>(entity =>
            {
                entity.HasKey(e => new { e.ProbRiesgCodigo, e.ProbRiesgTipoRiesgoCodigo, e.ProbRiesgEntradaNumero })
                    .HasName("PK_ProbabilidadRiego_1");

                entity.Property(e => e.ProbRiesgCodigo)
                    .HasColumnName("ProbRiesg_Codigo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProbRiesgTipoRiesgoCodigo).HasColumnName("ProbRiesg_TipoRiesgo_Codigo");

                entity.Property(e => e.ProbRiesgEntradaNumero).HasColumnName("ProbRiesg_Entrada_Numero");

                entity.Property(e => e.ProbRiesgEstimacion)
                    .HasColumnName("ProbRiesg_Estimacion")
                    .HasMaxLength(50);

                entity.Property(e => e.ProbRiesgProbabilidadCodigo).HasColumnName("ProbRiesg_Probabilidad_Codigo");

                entity.Property(e => e.ProbRiesgRiesgoCodigo)
                    .IsRequired()
                    .HasColumnName("ProbRiesg_Riesgo_Codigo")
                    .HasMaxLength(200);

                entity.HasOne(d => d.ProbRiesgEntradaNumeroNavigation)
                    .WithMany(p => p.ProbabilidadRiego)
                    .HasForeignKey(d => d.ProbRiesgEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProbabilidadRiego_EntradaHistoria");

                entity.HasOne(d => d.ProbRiesgProbabilidadCodigoNavigation)
                    .WithMany(p => p.ProbabilidadRiego)
                    .HasForeignKey(d => d.ProbRiesgProbabilidadCodigo)
                    .HasConstraintName("FK_ProbabilidadRiego_Probabilidad");

                entity.HasOne(d => d.ProbRiesgTipoRiesgoCodigoNavigation)
                    .WithMany(p => p.ProbabilidadRiego)
                    .HasForeignKey(d => d.ProbRiesgTipoRiesgoCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProbabilidadRiego_TipoRiesgo");
            });

            modelBuilder.Entity<Profesion>(entity =>
            {
                entity.HasKey(e => e.ProfCodigo);

                entity.Property(e => e.ProfCodigo)
                    .HasColumnName("Prof_Codigo")
                    .HasMaxLength(4);

                entity.Property(e => e.ProfDescripcion)
                    .IsRequired()
                    .HasColumnName("Prof_Descripcion")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Recomendacion>(entity =>
            {
                entity.HasKey(e => e.RecoCodigo);

                entity.Property(e => e.RecoCodigo).HasColumnName("Reco_Codigo");

                entity.Property(e => e.RecoDescripcion)
                    .IsRequired()
                    .HasColumnName("Reco_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RecomendacionDescripcion>(entity =>
            {
                entity.HasKey(e => e.RecDesCodigo);

                entity.Property(e => e.RecDesCodigo).HasColumnName("RecDes_Codigo");

                entity.Property(e => e.RecDesDescripcion)
                    .IsRequired()
                    .HasColumnName("RecDes_Descripcion")
                    .HasMaxLength(200);

                entity.Property(e => e.RecDesRecomendaciosCodigo).HasColumnName("RecDes_Recomendacios_Codigo");

                entity.HasOne(d => d.RecDesRecomendaciosCodigoNavigation)
                    .WithMany(p => p.RecomendacionDescripcion)
                    .HasForeignKey(d => d.RecDesRecomendaciosCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecomendacionDescripcion_Recomendacion");
            });

            modelBuilder.Entity<RecomendacionPaciente>(entity =>
            {
                entity.HasKey(e => new { e.RecoPacEntradaNumero, e.RecoPacRecomendacionCodigo });

                entity.Property(e => e.RecoPacEntradaNumero).HasColumnName("RecoPac_Entrada_Numero");

                entity.Property(e => e.RecoPacRecomendacionCodigo).HasColumnName("RecoPac_Recomendacion_Codigo");

                entity.HasOne(d => d.RecoPacEntradaNumeroNavigation)
                    .WithMany(p => p.RecomendacionPaciente)
                    .HasForeignKey(d => d.RecoPacEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecomendacionPaciente_EntradaHistoria");

                entity.HasOne(d => d.RecoPacRecomendacionCodigoNavigation)
                    .WithMany(p => p.RecomendacionPaciente)
                    .HasForeignKey(d => d.RecoPacRecomendacionCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecomendacionPaciente_RecomendacionDescripcion");
            });

            modelBuilder.Entity<Revision>(entity =>
            {
                entity.HasKey(e => e.ReviCodigo);

                entity.Property(e => e.ReviCodigo).HasColumnName("Revi_Codigo");

                entity.Property(e => e.ReviDescripcion)
                    .IsRequired()
                    .HasColumnName("Revi_Descripcion")
                    .HasMaxLength(50);

                entity.Property(e => e.ReviSistemaCodigo).HasColumnName("Revi_Sistema_Codigo");

                entity.HasOne(d => d.ReviSistemaCodigoNavigation)
                    .WithMany(p => p.Revision)
                    .HasForeignKey(d => d.ReviSistemaCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Revision_Sistema");
            });

            modelBuilder.Entity<RevisionSistema>(entity =>
            {
                entity.HasKey(e => new { e.RevSistEntradaNumero, e.RevSistRevisionCodigo });

                entity.Property(e => e.RevSistEntradaNumero).HasColumnName("RevSist_Entrada_Numero");

                entity.Property(e => e.RevSistRevisionCodigo).HasColumnName("RevSist_Revision_Codigo");

                entity.HasOne(d => d.RevSistEntradaNumeroNavigation)
                    .WithMany(p => p.RevisionSistema)
                    .HasForeignKey(d => d.RevSistEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RevisionSistema_EntradaHistoria");

                entity.HasOne(d => d.RevSistRevisionCodigoNavigation)
                    .WithMany(p => p.RevisionSistema)
                    .HasForeignKey(d => d.RevSistRevisionCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RevisionSistema_Revision");
            });

            modelBuilder.Entity<Riesgo>(entity =>
            {
                entity.HasKey(e => e.RiesgCodigo);

                entity.Property(e => e.RiesgCodigo).HasColumnName("Riesg_Codigo");

                entity.Property(e => e.RiesgDescripcion)
                    .IsRequired()
                    .HasColumnName("Riesg_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RiesgoOcupacional>(entity =>
            {
                entity.HasKey(e => new { e.RiegOcuRiesgoCodigo, e.RiegOcuEntradaNumero, e.RiegOcuCodigo });

                entity.Property(e => e.RiegOcuRiesgoCodigo).HasColumnName("RiegOcu_Riesgo_Codigo");

                entity.Property(e => e.RiegOcuEntradaNumero).HasColumnName("RiegOcu_Entrada_Numero");

                entity.Property(e => e.RiegOcuCodigo)
                    .HasColumnName("RiegOcu_Codigo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RiegOcuCargo)
                    .HasColumnName("RiegOcu_Cargo")
                    .HasMaxLength(50);

                entity.Property(e => e.RiegOcuEmpresa)
                    .IsRequired()
                    .HasColumnName("RiegOcu_Empresa")
                    .HasMaxLength(50);

                entity.Property(e => e.RiegOcuMeses)
                    .HasColumnName("RiegOcu_Meses")
                    .HasMaxLength(50);

                entity.Property(e => e.RiegOcuRiesgoEspecifico)
                    .HasColumnName("RiegOcu_RiesgoEspecifico")
                    .HasMaxLength(200);

                entity.HasOne(d => d.RiegOcuEntradaNumeroNavigation)
                    .WithMany(p => p.RiesgoOcupacional)
                    .HasForeignKey(d => d.RiegOcuEntradaNumero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RiesgoOcupacional_EntradaHistoria");

                entity.HasOne(d => d.RiegOcuRiesgoCodigoNavigation)
                    .WithMany(p => p.RiesgoOcupacional)
                    .HasForeignKey(d => d.RiegOcuRiesgoCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RiesgoOcupacional_Riesgo");
            });

            modelBuilder.Entity<SiNo>(entity =>
            {
                entity.HasKey(e => e.SiNoCodigo);

                entity.Property(e => e.SiNoCodigo)
                    .HasColumnName("SiNo_Codigo")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.SiNoDescripcion)
                    .HasColumnName("SiNo_Descripcion")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Sistema>(entity =>
            {
                entity.HasKey(e => e.SistCodigo);

                entity.Property(e => e.SistCodigo).HasColumnName("Sist_Codigo");

                entity.Property(e => e.SistDescripcion)
                    .IsRequired()
                    .HasColumnName("Sist_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TempoFumadores>(entity =>
            {
                entity.HasKey(e => e.Descripcion);

                entity.ToTable("TEMPO_FUMADORES");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30);

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TipResultado>(entity =>
            {
                entity.HasKey(e => e.TipResCodigo)
                    .HasName("PK_TipoDiagnostico");

                entity.Property(e => e.TipResCodigo).HasColumnName("TipRes_Codigo");

                entity.Property(e => e.TipResDescripcion)
                    .IsRequired()
                    .HasColumnName("TipRes_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.TipoIdeCodigo)
                    .HasName("PK_Tipo_Identificacion");

                entity.Property(e => e.TipoIdeCodigo)
                    .HasColumnName("TipoIde_Codigo")
                    .HasMaxLength(3);

                entity.Property(e => e.TipoIdeDescripcion)
                    .IsRequired()
                    .HasColumnName("TipoIde_Descripcion")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TipoExamen>(entity =>
            {
                entity.HasKey(e => e.TipoExamCodigo);

                entity.Property(e => e.TipoExamCodigo)
                    .HasColumnName("TipoExam_Codigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.TipoExamDescripcion)
                    .IsRequired()
                    .HasColumnName("TipoExam_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoExamenEnfasis>(entity =>
            {
                entity.HasKey(e => e.TipExEn);

                entity.Property(e => e.TipExEnTipoExamen).HasColumnName("TipExEn_TipoExamen");

                entity.HasOne(d => d.TipExEnEnfaisNavigation)
                    .WithMany(p => p.TipoExamenEnfasis)
                    .HasForeignKey(d => d.TipExEnEnfais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoExamenEnfasis_Enfasis");

                entity.HasOne(d => d.TipExEnTipoExamenNavigation)
                    .WithMany(p => p.TipoExamenEnfasis)
                    .HasForeignKey(d => d.TipExEnTipoExamen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoExamenEnfasis_TipoExamen");
            });

            modelBuilder.Entity<TipoExamenLaboratorio>(entity =>
            {
                entity.HasKey(e => e.TipExaLaboCodigo);

                entity.Property(e => e.TipExaLaboCodigo).HasColumnName("TipExaLabo_Codigo");

                entity.Property(e => e.TipExaLaboDescripcion)
                    .IsRequired()
                    .HasColumnName("TipExaLabo_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoInmunizacion>(entity =>
            {
                entity.HasKey(e => e.TipInmCodigo);

                entity.Property(e => e.TipInmCodigo).HasColumnName("TipInm_Codigo");

                entity.Property(e => e.TipInmDescripcion)
                    .HasColumnName("TipInm_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoRiesgo>(entity =>
            {
                entity.HasKey(e => e.TipoRiesgCodigo);

                entity.Property(e => e.TipoRiesgCodigo).HasColumnName("TipoRiesg_Codigo");

                entity.Property(e => e.TipoRiesgDescripcion)
                    .IsRequired()
                    .HasColumnName("TipoRiesg_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoSangre>(entity =>
            {
                entity.HasKey(e => e.TipSanCodigo);

                entity.Property(e => e.TipSanCodigo).HasColumnName("TipSan_Codigo");

                entity.Property(e => e.TipSanDescripcion)
                    .IsRequired()
                    .HasColumnName("TipSan_Descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuNombre)
                    .HasName("PK_Usuario_1");

                entity.Property(e => e.UsuNombre)
                    .HasColumnName("Usu_Nombre")
                    .HasMaxLength(10);

                entity.Property(e => e.UsuContraseña)
                    .IsRequired()
                    .HasColumnName("Usu_Contraseña")
                    .HasMaxLength(20);

                entity.Property(e => e.UsuEstado)
                    .HasColumnName("Usu_Estado")
                    .HasMaxLength(1);

                entity.Property(e => e.UsuFechaCaduca)
                    .HasColumnName("Usu_FechaCaduca")
                    .HasColumnType("date");

                entity.Property(e => e.UsuNombreCompleto)
                    .IsRequired()
                    .HasColumnName("Usu_NombreCompleto")
                    .HasMaxLength(100);

                entity.Property(e => e.UsuTipo)
                    .HasColumnName("Usu_Tipo")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<UsuarioModulo>(entity =>
            {
                entity.HasKey(e => new { e.UsuModUsuario, e.UsuModModulo });

                entity.Property(e => e.UsuModUsuario)
                    .HasColumnName("UsuMod_Usuario")
                    .HasMaxLength(10);

                entity.Property(e => e.UsuModModulo).HasColumnName("UsuMod_Modulo");

                entity.HasOne(d => d.UsuModModuloNavigation)
                    .WithMany(p => p.UsuarioModulo)
                    .HasForeignKey(d => d.UsuModModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioModulo_ModulosUsuario");

                entity.HasOne(d => d.UsuModUsuarioNavigation)
                    .WithMany(p => p.UsuarioModulo)
                    .HasForeignKey(d => d.UsuModUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioModulo_Usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
