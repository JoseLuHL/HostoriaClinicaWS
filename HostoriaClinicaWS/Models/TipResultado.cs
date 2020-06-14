using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class TipResultado
    {
        public TipResultado()
        {
            ExamenPracticado = new HashSet<ExamenPracticado>();
        }

        public int TipResCodigo { get; set; }
        public string TipResDescripcion { get; set; }

        public virtual ICollection<ExamenPracticado> ExamenPracticado { get; set; }
    }
}
