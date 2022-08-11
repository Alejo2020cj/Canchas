using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Reservas = new HashSet<Reserva>();
            Sexos = new HashSet<Sexo>();
            TipoUsuarios = new HashSet<TipoUsuario>();
        }

        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Departamento { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
        public virtual ICollection<Sexo> Sexos { get; set; }
        public virtual ICollection<TipoUsuario> TipoUsuarios { get; set; }
    }
}
