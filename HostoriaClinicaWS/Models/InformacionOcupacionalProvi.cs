using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class InformacionOcupacionalProvi
    {
        public int InfOcuNumero { get; set; }
        public string InfOcuPaciente { get; set; }
        public string InfOcuEmpresa { get; set; }
        public DateTime InfOcuFechaIngreso { get; set; }
        public string InfOcuJornada { get; set; }
        public string InfOcuCodOcupacion { get; set; }
        public string InfOcuArea { get; set; }
        public int? InfOcuCodEmpresa { get; set; }

        public virtual Empresa InfOcuCodEmpresaNavigation { get; set; }
    }
}
