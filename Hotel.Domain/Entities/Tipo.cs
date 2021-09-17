using System;
using System.Collections.Generic;



namespace Hotel.Domain.Entities
{
    public partial class Tipo
    {
        public Tipo()
        {
            THabitacion = new HashSet<Habitacion>();
        }

        public string IdTipo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Habitacion> THabitacion { get; set; }
    }
}
