using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class TipoExamenLaboratorio
    {
        public TipoExamenLaboratorio()
        {
            ExamenLaboratorio = new HashSet<ExamenLaboratorio>();
        }

        public int TipExaLaboCodigo { get; set; }
        public string TipExaLaboDescripcion { get; set; }

        public virtual ICollection<ExamenLaboratorio> ExamenLaboratorio { get; set; }
    }
}
