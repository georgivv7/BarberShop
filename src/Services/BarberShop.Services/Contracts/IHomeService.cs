using BarberShop.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BarberShop.Services.Contracts
{
    public interface IHomeService
    {
        IEnumerable<Contact> AllFeedbacks();
        void RegisterFeedBack(string firstName, string lastName, string message, string email);
    }
}
