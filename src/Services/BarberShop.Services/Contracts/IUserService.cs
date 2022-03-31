using BarberShop.Data.Models;
using System.Collections.Generic;

namespace BarberShop.Services.Contracts
{
    public interface IUserService
    {
        IEnumerable<Appointment> GetUserAppointments(string userId);   
        string GetUserAddress(string id);       
        string GetUserEmail(string id);     
    }
}
