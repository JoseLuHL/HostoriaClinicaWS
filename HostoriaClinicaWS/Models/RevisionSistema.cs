using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class RevisionSistema
    {
        public int RevSistEntradaNumero { get; set; }
        public int RevSistRevisionCodigo { get; set; }

        public virtual EntradaHistoria RevSistEntradaNumeroNavigation { get; set; }
        public virtual Revision RevSistRevisionCodigoNavigation { get; set; }
    }
}
