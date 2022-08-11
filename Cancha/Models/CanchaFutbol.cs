using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class CanchaFutbol
    {
        public CanchaFutbol()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int IdCanchaFut { get; set; }
        public string? NombreCancha { get; set; }
        public string? TamanoCancha { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
