using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class EntradaHistoria
    {
        public EntradaHistoria()
        {
            AccidenteLaboral = new HashSet<AccidenteLaboral>();
            AntecedentePersonal = new HashSet<AntecedentePersonal>();
            AntecednteFamiliar = new HashSet<AntecednteFamiliar>();
            DiagnosticoPaciente = new HashSet<DiagnosticoPaciente>();
            ExamenLaboratorio = new HashSet<ExamenLaboratorio>();
            ExamenPaciente = new HashSet<ExamenPaciente>();
            ExamenPracticado = new HashSet<ExamenPracticado>();
            HabitoPaciente = new HashSet<HabitoPaciente>();
            Inmunizar = new HashSet<Inmunizar>();
            ProbabilidadRiego = new HashSet<ProbabilidadRiego>();
            RecomendacionPaciente = new HashSet<RecomendacionPaciente>();
            RevisionSistema = new HashSet<RevisionSistema>();
            RiesgoOcupacional = new HashSet<RiesgoOcupacional>();
        }

        public int EntrNumero { get; set; }
        public string EntrIdPaciente { get; set; }
        public DateTime EntrFechaEntrada { get; set; }
        public string EntrDiagnostico { get; set; }
        public int EntrConceptoCodigo { get; set; }
        public string EntrRecomendacion { get; set; }
        public bool EntrReubicacion { get; set; }
        public int? EntrTipoExamenCodigo { get; set; }
        public int? EntEnfasis { get; set; }
        public bool? EntEstado { get; set; }
        public string EntConceptoAptitud { get; set; }
        public int? EntCodEps { get; set; }
        public int? EntCodArl { get; set; }
        public string EntMedico { get; set; }

        public virtual Medico EntMedicoNavigation { get; set; }
        public virtual Paciente EntrIdPacienteNavigation { get; set; }
        public virtual CicloMenstrual CicloMenstrual { get; set; }
        public virtual ExamenFisico1 ExamenFisico1 { get; set; }
        public virtual InformacionOcupacional InformacionOcupacional { get; set; }
        public virtual ICollection<AccidenteLaboral> AccidenteLaboral { get; set; }
        public virtual ICollection<AntecedentePersonal> AntecedentePersonal { get; set; }
        public virtual ICollection<AntecednteFamiliar> AntecednteFamiliar { get; set; }
        public virtual ICollection<DiagnosticoPaciente> DiagnosticoPaciente { get; set; }
        public virtual ICollection<ExamenLaboratorio> ExamenLaboratorio { get; set; }
        public virtual ICollection<ExamenPaciente> ExamenPaciente { get; set; }
        public virtual ICollection<ExamenPracticado> ExamenPracticado { get; set; }
        public virtual ICollection<HabitoPaciente> HabitoPaciente { get; set; }
        public virtual ICollection<Inmunizar> Inmunizar { get; set; }
        public virtual ICollection<ProbabilidadRiego> ProbabilidadRiego { get; set; }
        public virtual ICollection<RecomendacionPaciente> RecomendacionPaciente { get; set; }
        public virtual ICollection<RevisionSistema> RevisionSistema { get; set; }
        public virtual ICollection<RiesgoOcupacional> RiesgoOcupacional { get; set; }
    }
}
