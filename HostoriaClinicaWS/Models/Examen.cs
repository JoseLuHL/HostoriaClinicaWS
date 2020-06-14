using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Examen
    {
        public Examen()
        {
            ExamenPracticado = new HashSet<ExamenPracticado>();
        }

        public int ExamCodigo { get; set; }
        public string ExamDescripcion { get; set; }

        public virtual ICollection<ExamenPracticado> ExamenPracticado { get; set; }
    }
}
