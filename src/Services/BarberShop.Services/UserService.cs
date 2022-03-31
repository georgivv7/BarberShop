using BarberShop.Data.Common.Repositories;
using BarberShop.Data.Models;
using BarberShop.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BarberShop.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<BarberShopUser> usersRepository;
        private readonly IRepository<Appointment> appointmentsRepository;

        public UserService(IRepository<BarberShopUser> usersRepository,
                           IRepository<Appointment> appointmentsRepository)
        {
            this.usersRepository = usersRepository;
            this.appointmentsRepository = appointmentsRepository;
        }
        public string GetUserAddress(string id)
        {
            var user = this.usersRepository.All().SingleOrDefault(x => x.Id == id);

            return user.Address;
        }

        public IEnumerable<Appointment> GetUserAppointments(string userId)
        {
            var userAppointments = this.appointmentsRepository.All().Where(x => x.UserId == userId)
                .Include(x=>x.Barber)
                .OrderByDescending(x=>x.BookedOn);

            return userAppointments;
        }

        public string GetUserEmail(string id)
        {
            var user = this.usersRepository.All().Single(u=>u.Id == id);

            return user.Email;
        }

    }
}
