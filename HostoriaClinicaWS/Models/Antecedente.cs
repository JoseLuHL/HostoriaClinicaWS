using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Antecedente
    {
        public Antecedente()
        {
            AntecedentePersonal = new HashSet<AntecedentePersonal>();
        }

        public int AntCodigo { get; set; }
        public string AntDescripcion { get; set; }

        public virtual ICollection<AntecedentePersonal> AntecedentePersonal { get; set; }
    }
}
