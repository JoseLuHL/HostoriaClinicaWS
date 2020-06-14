using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class UsuarioModulo
    {
        public string UsuModUsuario { get; set; }
        public int UsuModModulo { get; set; }

        public virtual ModulosUsuario UsuModModuloNavigation { get; set; }
        public virtual Usuario UsuModUsuarioNavigation { get; set; }
    }
}
