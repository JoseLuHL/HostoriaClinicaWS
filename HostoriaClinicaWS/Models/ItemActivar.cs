using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ItemActivar
    {
        public int IntemCodigo { get; set; }
        public string IntemDescripcion { get; set; }
        public bool? IntemActivo { get; set; }
    }
}
