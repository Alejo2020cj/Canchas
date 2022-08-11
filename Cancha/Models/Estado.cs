using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class Estado
    {
        public string? Ocupado { get; set; }
        public string? Disponible { get; set; }
        public string? Mantenimiento { get; set; }
        public int? IdCanchaFut { get; set; }
        public int? IdCanchaVolei { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual CanchaFutbol? IdCanchaFutNavigation { get; set; }
        public virtual CanchaVoleibol? IdCanchaVoleiNavigation { get; set; }
    }
}
