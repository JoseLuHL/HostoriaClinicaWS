using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Revision
    {
        public Revision()
        {
            RevisionSistema = new HashSet<RevisionSistema>();
        }

        public int ReviCodigo { get; set; }
        public string ReviDescripcion { get; set; }
        public int ReviSistemaCodigo { get; set; }

        public virtual Sistema ReviSistemaCodigoNavigation { get; set; }
        public virtual ICollection<RevisionSistema> RevisionSistema { get; set; }
    }
}
