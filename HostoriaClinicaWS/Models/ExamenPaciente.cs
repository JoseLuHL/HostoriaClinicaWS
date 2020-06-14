using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ExamenPaciente
    {
        public int ExamPaciCodigo { get; set; }
        public int? ExamPaciExamenCodigo { get; set; }
        public int? ExamPaciEstado { get; set; }
        public int? ExamPaciNumeroEntrada { get; set; }
        public string ExamPaciObservacion { get; set; }

        public virtual ExamenFisico ExamPaciExamenCodigoNavigation { get; set; }
        public virtual EntradaHistoria ExamPaciNumeroEntradaNavigation { get; set; }
    }
}
