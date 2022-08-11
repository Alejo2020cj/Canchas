using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class TipoUsuario
    {
        public int IdTipoUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? IdUsuario { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
