using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            InformacionOcupacional = new HashSet<InformacionOcupacional>();
            InformacionOcupacionalProvi = new HashSet<InformacionOcupacionalProvi>();
        }

        public int EmprCodigo { get; set; }
        public string EmpreNit { get; set; }
        public string EmpreRazonSocial { get; set; }

        public virtual ICollection<InformacionOcupacional> InformacionOcupacional { get; set; }
        public virtual ICollection<InformacionOcupacionalProvi> InformacionOcupacionalProvi { get; set; }
    }
}
