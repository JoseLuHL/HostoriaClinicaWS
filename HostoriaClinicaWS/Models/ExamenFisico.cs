using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ExamenFisico
    {
        public ExamenFisico()
        {
            ExamenPaciente = new HashSet<ExamenPaciente>();
        }

        public int ExFiCodigo { get; set; }
        public string ExFiDescripcion { get; set; }

        public virtual ICollection<ExamenPaciente> ExamenPaciente { get; set; }
    }
}
