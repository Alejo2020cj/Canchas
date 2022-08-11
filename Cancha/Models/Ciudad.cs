using System;
using System.Collections.Generic;

namespace Cancha.Models
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            Sedes = new HashSet<Sede>();
        }

        public int IdCiudad { get; set; }
        public string? Nombre { get; set; }
        public string? Departamento { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual ICollection<Sede> Sedes { get; set; }
    }
}
