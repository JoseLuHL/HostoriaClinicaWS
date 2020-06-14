using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class TipoRiesgo
    {
        public TipoRiesgo()
        {
            ProbabilidadRiego = new HashSet<ProbabilidadRiego>();
        }

        public int TipoRiesgCodigo { get; set; }
        public string TipoRiesgDescripcion { get; set; }

        public virtual ICollection<ProbabilidadRiego> ProbabilidadRiego { get; set; }
    }
}
