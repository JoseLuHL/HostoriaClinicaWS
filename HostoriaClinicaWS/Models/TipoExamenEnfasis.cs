using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class TipoExamenEnfasis
    {
        public int TipExEn { get; set; }
        public int TipExEnTipoExamen { get; set; }
        public int TipExEnEnfais { get; set; }

        public virtual Enfasis TipExEnEnfaisNavigation { get; set; }
        public virtual TipoExamen TipExEnTipoExamenNavigation { get; set; }
    }
}
