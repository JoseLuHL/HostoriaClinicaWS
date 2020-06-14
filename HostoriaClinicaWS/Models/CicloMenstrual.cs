using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class CicloMenstrual
    {
        public int CicMensEntradaNumero { get; set; }
        public DateTime CicMensFechaUltimaRegla { get; set; }
        public int CicMensHijosSanos { get; set; }
        public string CicMensGestaciones { get; set; }
        public string CicMensPartos { get; set; }
        public string CicMensAbortos { get; set; }
        public string CicMensHijos { get; set; }
        public string CicMensResultadoCitologia { get; set; }
        public bool? CicMensPlanificacion { get; set; }
        public string CicMensEdadmenopausia { get; set; }
        public string CicMensEdadmenarca { get; set; }
        public string CicMensMetodo { get; set; }

        public virtual EntradaHistoria CicMensEntradaNumeroNavigation { get; set; }
    }
}
