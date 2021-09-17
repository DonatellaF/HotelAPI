using System;
using System.Collections.Generic;


namespace Hotel.Domain.Entities
{
    public partial class Alquiler
    {
        public int IdAlquiler { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public string FkVendedor { get; set; }
        public int? FkCliente { get; set; }
        public int? FkHabitacion { get; set; }

        public virtual Cliente FkClienteNavigation { get; set; }
        public virtual Habitacion FkHabitacionNavigation { get; set; }
        public virtual Vendedor FkVendedorNavigation { get; set; }
    }
}
