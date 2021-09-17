using Hotel.Domain.Interfaces.RepositoriesInterface;
using Hotel.Infra.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infra.Repositories
{
    public class HotelRespository : IHotelRepository
    {
        public string GetCliente()
        {
            using (var bd = new HotelContext())
            {
                var cliente = bd.Cliente.Where(e => e.IdCliente == 14).FirstOrDefault();
                return cliente.Nombre;
            }
        }
    }
}
