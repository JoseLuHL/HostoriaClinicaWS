using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class EntradaProvisional
    {
        public string EntrIdPaciente { get; set; }
        public string EntrFechaEntrada { get; set; }
        public int EntrConceptoCodigo { get; set; }
        public int? EntrTipoExamenCodigo { get; set; }
        public int? EntEnfasis { get; set; }
        public int EntCodigo { get; set; }
        public bool? EntEstado { get; set; }

        public virtual TipoExamenEnfasis EntEnfasisNavigation { get; set; }
        public virtual Paciente EntrIdPacienteNavigation { get; set; }
        public virtual TipoExamen EntrTipoExamenCodigoNavigation { get; set; }
    }
}
