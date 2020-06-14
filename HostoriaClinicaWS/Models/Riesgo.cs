using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Riesgo
    {
        public Riesgo()
        {
            RiesgoOcupacional = new HashSet<RiesgoOcupacional>();
        }

        public int RiesgCodigo { get; set; }
        public string RiesgDescripcion { get; set; }

        public virtual ICollection<RiesgoOcupacional> RiesgoOcupacional { get; set; }
    }
}
