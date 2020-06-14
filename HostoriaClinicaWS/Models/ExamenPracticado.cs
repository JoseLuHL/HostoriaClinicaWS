using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ExamenPracticado
    {
        public int ExaPracExamenCodigo { get; set; }
        public int ExaPracEntradaNumero { get; set; }
        public int? ExaPracResultado { get; set; }
        public byte[] ExaPracAjuntar { get; set; }
        public DateTime ExaPracFechaExamen { get; set; }
        public int ExaPracCodigo { get; set; }

        public virtual EntradaHistoria ExaPracEntradaNumeroNavigation { get; set; }
        public virtual Examen ExaPracExamenCodigoNavigation { get; set; }
        public virtual TipResultado ExaPracResultadoNavigation { get; set; }
    }
}
