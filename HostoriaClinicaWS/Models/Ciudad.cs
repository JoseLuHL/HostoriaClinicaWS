using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Ciudad
    {
        public string CiudCodDepto { get; set; }
        public string CiudCodigo { get; set; }
        public string CiudNombre { get; set; }

        public virtual Departamento CiudCodDeptoNavigation { get; set; }
    }
}
