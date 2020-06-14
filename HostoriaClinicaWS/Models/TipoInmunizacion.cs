using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class TipoInmunizacion
    {
        public TipoInmunizacion()
        {
            Inmunizar = new HashSet<Inmunizar>();
        }

        public int TipInmCodigo { get; set; }
        public string TipInmDescripcion { get; set; }

        public virtual ICollection<Inmunizar> Inmunizar { get; set; }
    }
}
