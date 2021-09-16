using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infra.Data.Repositories
{
    public class HotelRespository
    {
        public string GetCliente()
        {
            using (var bd = new bdHotelEntities())
            {
                var cliente = bd.tCliente.Where(e => e.idCliente == 13).FirstOrDefault();
                return cliente.nombre;
            }
        }
    }
}
