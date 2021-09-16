using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infra.Repositories
{
    public class HotelRespository
    {
        public string GetCliente()
        {
            using (var bd = new bdHotelEntities())
            {
                var cliente = bd.tCliente.Where(e => e.idCliente == 14).FirstOrDefault();
                return cliente.nombre;
            }
        }
    }
}
