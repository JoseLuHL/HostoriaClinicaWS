using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ProbabilidadRiego
    {
        public int ProbRiesgCodigo { get; set; }
        public int ProbRiesgTipoRiesgoCodigo { get; set; }
        public int ProbRiesgEntradaNumero { get; set; }
        public string ProbRiesgRiesgoCodigo { get; set; }
        public int? ProbRiesgProbabilidadCodigo { get; set; }
        public string ProbRiesgEstimacion { get; set; }

        public virtual EntradaHistoria ProbRiesgEntradaNumeroNavigation { get; set; }
        public virtual Probabilidad ProbRiesgProbabilidadCodigoNavigation { get; set; }
        public virtual TipoRiesgo ProbRiesgTipoRiesgoCodigoNavigation { get; set; }
    }
}
