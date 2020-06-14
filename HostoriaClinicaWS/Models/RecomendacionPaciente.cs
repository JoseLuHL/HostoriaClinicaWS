using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class RecomendacionPaciente
    {
        public int RecoPacEntradaNumero { get; set; }
        public int RecoPacRecomendacionCodigo { get; set; }

        public virtual EntradaHistoria RecoPacEntradaNumeroNavigation { get; set; }
        public virtual RecomendacionDescripcion RecoPacRecomendacionCodigoNavigation { get; set; }
    }
}
