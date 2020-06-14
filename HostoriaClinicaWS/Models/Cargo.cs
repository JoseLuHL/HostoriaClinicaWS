using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            InformacionOcupacional = new HashSet<InformacionOcupacional>();
        }

        public int CargCodigo { get; set; }
        public string CargDescripcion { get; set; }

        public virtual ICollection<InformacionOcupacional> InformacionOcupacional { get; set; }
    }
}
