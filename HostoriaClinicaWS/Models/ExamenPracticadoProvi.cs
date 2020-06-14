using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ExamenPracticadoProvi
    {
        public string ExaPacPaciente { get; set; }
        public int ExaPracExamenCodigo { get; set; }
        public int? ExaPracResultado { get; set; }
        public byte[] ExaPracAjuntar { get; set; }
        public DateTime ExaPracFechaExamen { get; set; }

        public virtual Examen ExaPracExamenCodigoNavigation { get; set; }
        public virtual TipResultado ExaPracResultadoNavigation { get; set; }
    }
}
