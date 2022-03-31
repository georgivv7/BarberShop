using BarberShop.Data;
using BarberShop.Data.Common.Repositories;
using BarberShop.Data.Models;
using BarberShop.Data.Repositories;
using BarberShop.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BarberShop.Services.Tests
{
    public class BarbersServiceTests
    {
        [Fact]
        public void AllShouldReturnCorrectNumber()
        {
            var barbersRepository = new Mock<IRepository<Barber>>();

            barbersRepository.Setup(r => r.All()).Returns(new List<Barber>()
            {
                new Barber(),
                new Barber(),
                new Barber()
            }.AsQueryable());

            var service = new BarbersService(barbersRepository.Object, null, null);
            Assert.Equal(3, service.All().Count());
        }

        [Fact]
        public void AddAppointmentShouldActuallyAddAppointmentToDatabase()
        {
            var options = new DbContextOptionsBuilder<BarberShopDbContext>()
                .UseInMemoryDatabase(databaseName: "Unique_Db_Name_627895")
                .Options;
            var dbContext = new BarberShopDbContext(options);
            dbContext.Barbers.Add(new Barber()
            {
                Id = "1"
            });
            dbContext.Users.Add(new BarberShopUser()
            {
                Id = "2"
            });
            dbContext.SaveChanges();

            var barbersRepository = new DbRepository<Barber>(dbContext);    
            var appointmentsRepository = new DbRepository<Appointment>(dbContext);  
            var servicesRepository = new DbRepository<Service>(dbContext);

            var barbersService = new BarbersService(barbersRepository,appointmentsRepository,servicesRepository);
            var bookedFor = "03/31/2022";
            var description = "short description";
            var barberServiceName = "Haircut";
            var successful = barbersService.AddAppointment(bookedFor, description, barberServiceName,
                "2", "1");

            Assert.True(successful);
        }
    }
}
