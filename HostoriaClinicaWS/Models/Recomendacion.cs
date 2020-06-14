using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Recomendacion
    {
        public Recomendacion()
        {
            RecomendacionDescripcion = new HashSet<RecomendacionDescripcion>();
        }

        public int RecoCodigo { get; set; }
        public string RecoDescripcion { get; set; }

        public virtual ICollection<RecomendacionDescripcion> RecomendacionDescripcion { get; set; }
    }
}
