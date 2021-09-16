using Hotel.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Services
{
    public class HotelService
    {
        public HotelRespository hotelRespository { get; set; }
        public HotelService()
        {
            hotelRespository = new HotelRespository();
        }

        public string GetCliente()
        {
            return hotelRespository.GetCliente();
        }
    }
}
