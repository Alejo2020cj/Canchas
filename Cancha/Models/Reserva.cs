using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class Reserva
    {
        public int IdReserva { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdSede { get; set; }
        public int? IdCanchaFut { get; set; }
        public int? IdCanchaVolei { get; set; }
        public int? IdCiudad { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual CanchaFutbol? IdCanchaFutNavigation { get; set; }
        public virtual CanchaVoleibol? IdCanchaVoleiNavigation { get; set; }
        public virtual Sede? IdSedeNavigation { get; set; }
        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
