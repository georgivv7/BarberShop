using BarberShop.Data.Common.Repositories;
using BarberShop.Data.Models;
using BarberShop.Data.Models.Enums;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BarberShop.Services.Tests
{
    public class BarberServicesServiceTests
    {
        [Fact]
        public void GetAllServicesShouldActuallyReturnAllServices()
        {
            var serviceRepository = new Mock<IRepository<Service>>();
            serviceRepository.Setup(r => r.All()).Returns(new List<Service>()
            {
                new Service()

            }.AsQueryable());

            var service = new BarberServicesService(serviceRepository.Object);
            Assert.Single(service.All());
        }

        [Fact]
        public void GetServiceShouldReturnTheActualService()
        {
            var serviceRepository = new Mock<IRepository<Service>>();
            serviceRepository.Setup(r => r.All()).Returns(new List<Service>()
            {
                new Service
                {
                    Id = "1",
                    Name = HairAndBeardStyles.Haircut
                },
                new Service
                {
                    Id = "2",
                    Name = HairAndBeardStyles.SkinFade
                },
                new Service
                {
                    Id="3",
                    Name = HairAndBeardStyles.BeardTrim
                }
            }.AsQueryable());

            var service = new BarberServicesService(serviceRepository.Object);
            var actualServiceName = service.GetService("2").Name.ToString();
            Assert.Equal("SkinFade", actualServiceName);
        }
    }
}
