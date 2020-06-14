using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class RecomendacionDescripcion
    {
        public RecomendacionDescripcion()
        {
            RecomendacionPaciente = new HashSet<RecomendacionPaciente>();
        }

        public int RecDesCodigo { get; set; }
        public string RecDesDescripcion { get; set; }
        public int RecDesRecomendaciosCodigo { get; set; }

        public virtual Recomendacion RecDesRecomendaciosCodigoNavigation { get; set; }
        public virtual ICollection<RecomendacionPaciente> RecomendacionPaciente { get; set; }
    }
}
