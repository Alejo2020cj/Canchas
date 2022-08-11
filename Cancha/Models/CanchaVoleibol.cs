using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class CanchaVoleibol
    {
        public CanchaVoleibol()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int IdCanchaVolei { get; set; }
        public string? NombreCancha { get; set; }
        public string? TamanoCancha { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
