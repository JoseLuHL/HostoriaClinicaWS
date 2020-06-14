using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Equilibro
    {
        public Equilibro()
        {
            EquilibrioDes = new HashSet<EquilibrioDes>();
        }

        public int EquiCodigo { get; set; }
        public string EquiDescripcion { get; set; }

        public virtual ICollection<EquilibrioDes> EquilibrioDes { get; set; }
    }
}
