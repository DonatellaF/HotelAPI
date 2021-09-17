using System;
using System.Collections.Generic;



namespace Hotel.Domain.Entities
{
    public partial class Vendedor
    {
        public string IdVendedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Observacion { get; set; }
        public decimal? Sueldo { get; set; }
    }
}
