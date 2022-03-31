using BarberShop.Data.Models;
using BarberShop.Data.Models.Enums;
using System.Linq;

namespace BarberShop.Services.Contracts
{
    public interface IBarberServicesService
    {
        IQueryable<Service> All();
        Service GetService(string serviceId);
    }
}
