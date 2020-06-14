using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class EquilibroPaciente
    {
        public int EqiPaCidigo { get; set; }
        public int EqiPaEquilibro { get; set; }
        public int EqiPaHistoriaNumero { get; set; }
        public int EqiPaEstado { get; set; }
        public string EqiPaReflejos { get; set; }
        public string EqiPaMarcha { get; set; }
        public string EqiPaPiel { get; set; }

        public virtual EquilibrioDes EqiPaEquilibroNavigation { get; set; }
        public virtual EstadoEquilibrioPaciente EqiPaEstadoNavigation { get; set; }
    }
}
