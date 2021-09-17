using Hotel.Domain.Interfaces.RepositoriesInterface;
using Hotel.Domain.Interfaces.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Services
{
    public class HotelService : IHotelService
    {
        public IHotelRepository _hotelRepository;
        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public string GetCliente()
        {
            return _hotelRepository.GetCliente();
        }
    }
}
