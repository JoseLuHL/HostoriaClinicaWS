using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class RiesgoOcupacional
    {
        public int RiegOcuCodigo { get; set; }
        public int RiegOcuRiesgoCodigo { get; set; }
        public int RiegOcuEntradaNumero { get; set; }
        public string RiegOcuRiesgoEspecifico { get; set; }
        public string RiegOcuEmpresa { get; set; }
        public string RiegOcuCargo { get; set; }
        public string RiegOcuMeses { get; set; }

        public virtual EntradaHistoria RiegOcuEntradaNumeroNavigation { get; set; }
        public virtual Riesgo RiegOcuRiesgoCodigoNavigation { get; set; }
    }
}
