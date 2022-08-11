using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class Sexo
    {
        public int IdSexo { get; set; }
        public string? Femenino { get; set; }
        public string? Masculino { get; set; }
        public int? IdUsuario { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
