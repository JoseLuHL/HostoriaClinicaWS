using System;
using System.Collections.Generic;

namespace HostoriaClinicaWS.Models
{
    public partial class Cliente
    {
        public string CliTipoIdentificacion { get; set; }
        public string CliIdentificacion { get; set; }
        public string CliNombre1 { get; set; }
        public string CliNombre2 { get; set; }
        public string CliApellido1 { get; set; }
        public string CliApellido2 { get; set; }
        public DateTime CliFechaNacimiento { get; set; }
        public string CliCodGenero { get; set; }
        public string CliCodDepto { get; set; }
        public string CliCodCiudad { get; set; }
        public string CliDireccion { get; set; }
        public int CliCodNivelEducativo { get; set; }
        public string CliCodProfesion { get; set; }
        public int CliTipoSangre { get; set; }
        public int CliEstadoCivil { get; set; }
        public string CliTelefono { get; set; }
        public byte[] CliFoto { get; set; }
        public byte[] CliHuella { get; set; }
        public byte[] CliFirma { get; set; }
        public int CliDominanciaCodigo { get; set; }
        public DateTime? CliFecha { get; set; }
        public int? CliCodLista { get; set; }
    }
}
