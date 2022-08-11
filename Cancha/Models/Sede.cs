using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class Sede
    {
        public Sede()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int IdSede { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Sur { get; set; }
        public string? Norte { get; set; }
        public int? IdCiudad { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual Ciudad? IdCiudadNavigation { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
