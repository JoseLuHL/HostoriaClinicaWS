using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class EquilibrioDes
    {
        public EquilibrioDes()
        {
            EquilibroPaciente = new HashSet<EquilibroPaciente>();
        }

        public int EqDesCodigo { get; set; }
        public string EqDesDescripcion { get; set; }
        public int EqDesEqilibrio { get; set; }

        public virtual Equilibro EqDesEqilibrioNavigation { get; set; }
        public virtual ICollection<EquilibroPaciente> EquilibroPaciente { get; set; }
    }
}
