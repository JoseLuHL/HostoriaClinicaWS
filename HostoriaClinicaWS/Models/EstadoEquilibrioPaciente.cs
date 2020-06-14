using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class EstadoEquilibrioPaciente
    {
        public EstadoEquilibrioPaciente()
        {
            EquilibroPaciente = new HashSet<EquilibroPaciente>();
        }

        public int EsEquiCodigo { get; set; }
        public string EsEquiDescripcion { get; set; }

        public virtual ICollection<EquilibroPaciente> EquilibroPaciente { get; set; }
    }
}
