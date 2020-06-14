using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class TipoExamen
    {
        public TipoExamen()
        {
            TipoExamenEnfasis = new HashSet<TipoExamenEnfasis>();
        }

        public int TipoExamCodigo { get; set; }
        public string TipoExamDescripcion { get; set; }

        public virtual ICollection<TipoExamenEnfasis> TipoExamenEnfasis { get; set; }
    }
}
