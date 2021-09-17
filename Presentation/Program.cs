using Hotel.Domain.Interfaces.RepositoriesInterface;
using Hotel.Domain.Interfaces.ServicesInterfaces;
using Hotel.Domain.Services;
using Hotel.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Generamos la coleccion de servicios
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IHotelService, HotelService>();
            serviceCollection.AddTransient<IHotelRepository, HotelRespository>();

            var services = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hotel(services.GetService<IHotelService>()));
        }
    }
}
