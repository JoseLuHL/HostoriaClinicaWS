using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class DiagnosticoPaciente
    {
        public int DiagPaciNumeroHistoria { get; set; }
        public string DiagPaciCodDiagnostico { get; set; }

        public virtual Diagnostico DiagPaciCodDiagnosticoNavigation { get; set; }
        public virtual EntradaHistoria DiagPaciNumeroHistoriaNavigation { get; set; }
    }
}
