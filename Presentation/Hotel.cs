using Hotel.Domain.Interfaces.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Hotel : Form
    {
        public IHotelService _hotelService;
        public Hotel(IHotelService hotelService)
        {
            InitializeComponent();
            _hotelService = hotelService;
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            this.txtNombreValue.Text = _hotelService.GetCliente();
        }
    }
}
