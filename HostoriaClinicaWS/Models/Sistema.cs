using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Sistema
    {
        public Sistema()
        {
            Revision = new HashSet<Revision>();
        }

        public int SistCodigo { get; set; }
        public string SistDescripcion { get; set; }

        public virtual ICollection<Revision> Revision { get; set; }
    }
}
