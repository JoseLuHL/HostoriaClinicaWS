using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class AntecednteFamiliar
    {
        public int AntFamNumero { get; set; }
        public string AntFamEnfermedadCodigo { get; set; }
        public int AntFamEntradaNumero { get; set; }
        public string AntFamParentesco { get; set; }
        public bool AntFamMortalidad { get; set; }

        public virtual EntradaHistoria AntFamEntradaNumeroNavigation { get; set; }
    }
}
