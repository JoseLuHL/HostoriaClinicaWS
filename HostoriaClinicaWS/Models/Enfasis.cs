using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Enfasis
    {
        public Enfasis()
        {
            TipoExamenEnfasis = new HashSet<TipoExamenEnfasis>();
        }

        public int EnfaCodigo { get; set; }
        public string EnfaDescripcion { get; set; }

        public virtual ICollection<TipoExamenEnfasis> TipoExamenEnfasis { get; set; }
    }
}
