using Hotel.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.API
{
    public class HotelController
    {
        public HotelService hotelService { get; set; }
        public HotelController()
        {
            hotelService = new HotelService();
        }
        public string GetCliente()
        {
            return hotelService.GetCliente();
        }
    }
}
