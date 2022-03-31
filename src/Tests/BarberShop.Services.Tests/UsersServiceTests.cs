using BarberShop.Data.Common.Repositories;
using BarberShop.Data.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BarberShop.Services.Tests
{
    public class UsersServiceTests
    {
        [Fact]
        public void GetUserBooksShouldReturnAllUserBooks()
        {
            var usersRepository = new Mock<IRepository<BarberShopUser>>();
            usersRepository.Setup(r => r.All()).Returns(new List<BarberShopUser>()
            {
                new BarberShopUser()
                {
                    Id = "1"
                }
            }.AsQueryable());

            var appointmentsRepository = new Mock<IRepository<Appointment>>();
            appointmentsRepository.Setup(r => r.All()).Returns(new List<Appointment>()
            {
                new Appointment()
                {
                    Id = "2",
                    UserId = "1"
                },
                new Appointment()
                {
                    Id = "3",
                    UserId = "1"
                }
            }.AsQueryable());

            var service = new UserService(usersRepository.Object, appointmentsRepository.Object);
            Assert.Equal(2, service.GetUserAppointments("1").Count());
        }
        [Fact]
        public void GetUserAddressShouldReturnUsersValidAddress()
        {
            var usersRepository = new Mock<IRepository<BarberShopUser>>();
            usersRepository.Setup(r => r.All()).Returns(new List<BarberShopUser>()
            {
                new BarberShopUser()
                {
                    Id = "1",
                    Address = "Sample address"
                }
            }.AsQueryable());

            var service = new UserService(usersRepository.Object,null);
            Assert.Same("Sample address", service.GetUserAddress("1"));
        }

        [Fact]
        public void GetUserEmailShouldReturnUserValidEmail()
        {
            var usersRepository = new Mock<IRepository<BarberShopUser>>();
            usersRepository.Setup(r => r.All()).Returns(new List<BarberShopUser>()
            {
                new BarberShopUser()
                {
                    Id = "1",
                    Email = "Sample email"
                }
            }.AsQueryable());

            var service = new UserService(usersRepository.Object,null);
            Assert.Same("Sample email", service.GetUserEmail("1"));
        }
    }
}
