using BarberShop.Data.Models;
using System.Linq;

namespace BarberShop.Services.Contracts
{
    public interface IBarbersService
    {
        bool AddAppointment(string bookedFor, string description,string barberServiceName,     
                                                    string userId, string barberId);    
        IQueryable<Barber> All();       
        TViewModel Details<TViewModel>(string id);   
    }
}
