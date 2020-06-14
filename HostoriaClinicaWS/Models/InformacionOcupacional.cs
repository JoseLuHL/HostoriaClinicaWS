using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class InformacionOcupacional
    {
        public int InfOcuNumero { get; set; }
        public int InfOcuEntradaNumero { get; set; }
        public DateTime InfOcuFechaIngreso { get; set; }
        public DateTime InfOcuFechaCargoActual { get; set; }
        public string InfOcuJornada { get; set; }
        public int? InfOcuCodOcupacion { get; set; }
        public string InfOcuArea { get; set; }
        public string InfOcuDescripcionFunciones { get; set; }
        public string InfOcuMaquinaria { get; set; }
        public string InfOcuHerramienta { get; set; }
        public string InfOcuMateriaPrima { get; set; }
        public string InfOcuElementoProte { get; set; }
        public string InfOcuEmpresa { get; set; }
        public int? InfOcuCodEmpresa { get; set; }

        public virtual Empresa InfOcuCodEmpresaNavigation { get; set; }
        public virtual Cargo InfOcuCodOcupacionNavigation { get; set; }
        public virtual EntradaHistoria InfOcuEntradaNumeroNavigation { get; set; }
    }
}
