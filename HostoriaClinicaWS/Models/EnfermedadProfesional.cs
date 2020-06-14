using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class EnfermedadProfesional
    {
        public int EnfProEnfermedadCodigo { get; set; }
        public int EnfProEntradaNumero { get; set; }
        public string EnfProEmpresa { get; set; }
        public DateTime EnfProFechaDiagnostico { get; set; }
        public int EnfProCodigo { get; set; }
    }
}
