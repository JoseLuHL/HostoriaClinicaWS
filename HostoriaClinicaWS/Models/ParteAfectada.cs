using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ParteAfectada
    {
        public ParteAfectada()
        {
            AccidenteLaboral = new HashSet<AccidenteLaboral>();
        }

        public int PartACodigo { get; set; }
        public string PartADescripcion { get; set; }

        public virtual ICollection<AccidenteLaboral> AccidenteLaboral { get; set; }
    }
}
