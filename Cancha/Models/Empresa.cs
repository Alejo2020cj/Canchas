using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class Empresa
    {
        public int IdEmpresa { get; set; }
        public string? NombreComercial { get; set; }
        public string? RazonSocial { get; set; }
        public string? Nit { get; set; }
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Departamento { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public int? Bhabilitado { get; set; }
    }
}
