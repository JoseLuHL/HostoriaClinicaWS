using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ExamenFisico1
    {
        public int ExaFisiEntradaNumero { get; set; }
        public string ExaFisiPresionArterial { get; set; }
        public string ExaFisiFrecuenciaCardiaca { get; set; }
        public string ExaFisiLateracidad { get; set; }
        public string ExaFisiPeso { get; set; }
        public string ExaFisiTalla { get; set; }
        public string ExaFisiPerimetroCintura { get; set; }
        public string ExaFisiImc { get; set; }
        public string ExaFisiInterpretacion { get; set; }

        public virtual EntradaHistoria ExaFisiEntradaNumeroNavigation { get; set; }
    }
}
