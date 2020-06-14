using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class ModulosUsuario
    {
        public ModulosUsuario()
        {
            UsuarioModulo = new HashSet<UsuarioModulo>();
        }

        public int ModCodigo { get; set; }
        public string ModDescripcion { get; set; }

        public virtual ICollection<UsuarioModulo> UsuarioModulo { get; set; }
    }
}
