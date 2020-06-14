using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ExamenLaboratorio
    {
        public int ExaLaboEntradaNumero { get; set; }
        public int ExaLaboExamenCodigo { get; set; }

        public virtual EntradaHistoria ExaLaboEntradaNumeroNavigation { get; set; }
        public virtual TipoExamenLaboratorio ExaLaboExamenCodigoNavigation { get; set; }
    }
}
