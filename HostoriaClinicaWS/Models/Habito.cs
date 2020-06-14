using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Habito
    {
        public Habito()
        {
            HabitoPaciente = new HashSet<HabitoPaciente>();
        }

        public int HabCodigo { get; set; }
        public string HabDescripcion { get; set; }

        public virtual ICollection<HabitoPaciente> HabitoPaciente { get; set; }
    }
}
