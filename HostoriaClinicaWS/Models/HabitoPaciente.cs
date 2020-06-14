using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class HabitoPaciente
    {
        public int HabPacHabitoCodigo { get; set; }
        public int HabPacEntradaNumero { get; set; }
        public string HabPacCaracteristica { get; set; }
        public string HabPacFrecuencia { get; set; }
        public string HabPacTiempo { get; set; }
        public string HabPacObservacion { get; set; }

        public virtual EntradaHistoria HabPacEntradaNumeroNavigation { get; set; }
        public virtual Habito HabPacHabitoCodigoNavigation { get; set; }
    }
}
