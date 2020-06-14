using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class AntecedentePersonal
    {
        public int AntPerNumero { get; set; }
        public int AntPerAntecedendeCodigo { get; set; }
        public int AntPerEntradaNumero { get; set; }
        public string AntPerDiagnostico { get; set; }
        public string AntPerObservacion { get; set; }

        public virtual Antecedente AntPerAntecedendeCodigoNavigation { get; set; }
        public virtual EntradaHistoria AntPerEntradaNumeroNavigation { get; set; }
    }
}
