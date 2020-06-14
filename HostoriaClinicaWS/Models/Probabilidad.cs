using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Probabilidad
    {
        public Probabilidad()
        {
            ProbabilidadRiego = new HashSet<ProbabilidadRiego>();
        }

        public int ProbCodigo { get; set; }
        public string ProbDescripcion { get; set; }

        public virtual ICollection<ProbabilidadRiego> ProbabilidadRiego { get; set; }
    }
}
