using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Diagnostico
    {
        public Diagnostico()
        {
            DiagnosticoPaciente = new HashSet<DiagnosticoPaciente>();
        }

        public int DiagId { get; set; }
        public string DiagCodigo { get; set; }
        public string DiagDescripcion { get; set; }

        public virtual ICollection<DiagnosticoPaciente> DiagnosticoPaciente { get; set; }
    }
}
