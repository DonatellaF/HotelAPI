using System;
using System.Collections.Generic;


namespace Hotel.Domain.Entities
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Observacion { get; set; }
    }
}
