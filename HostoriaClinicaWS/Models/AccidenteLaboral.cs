using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class AccidenteLaboral
    {
        public int AccLabCodigo { get; set; }
        public DateTime AccLabFecha { get; set; }
        public int AccLabEntradaNumero { get; set; }
        public string AccLabEmpresa { get; set; }
        public string AccLabNaturaleza { get; set; }
        public int AccLabParteAfectadaCodigo { get; set; }
        public string AccLabSecuela { get; set; }
        public string AccLabDiasIncapacidad { get; set; }

        public virtual EntradaHistoria AccLabEntradaNumeroNavigation { get; set; }
        public virtual ParteAfectada AccLabParteAfectadaCodigoNavigation { get; set; }
    }
}
