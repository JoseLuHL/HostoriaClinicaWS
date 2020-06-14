using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Inmunizar
    {
        public int InmuEntradaNumero { get; set; }
        public int InmuTipoInmunizacionCodigo { get; set; }
        public DateTime InmuFecha { get; set; }
        public string InmuDosis { get; set; }
        public int InmuCodigo { get; set; }

        public virtual EntradaHistoria InmuEntradaNumeroNavigation { get; set; }
        public virtual TipoInmunizacion InmuTipoInmunizacionCodigoNavigation { get; set; }
    }
}
