using System;
using System.Collections.Generic;


namespace Hotel.Domain.Entities
{
    public partial class Habitacion
    {
        public int IdHabitacion { get; set; }
        public int? NumeroCamas { get; set; }
        public string Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public string FkTipo { get; set; }
        public string Observacion { get; set; }

        public virtual Tipo FkTipoNavigation { get; set; }
    }
}
