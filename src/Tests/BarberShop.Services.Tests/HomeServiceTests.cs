using BarberShop.Data;
using BarberShop.Data.Common.Repositories;
using BarberShop.Data.Models;
using BarberShop.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BarberShop.Services.Tests
{
    public class HomeServiceTests
    {
        [Fact]
        public void AllFeedbacksActuallyReturnsAllOfTheFeedbacks()
        {
            var feedbackRepository = new Mock<IRepository<Contact>>();
            feedbackRepository.Setup(r => r.All()).Returns(new List<Contact>()
            {
                new Contact(),
                new Contact(),
                new Contact()
            }.AsQueryable());

            var service = new HomeService(feedbackRepository.Object);
            Assert.Equal(3, service.AllFeedbacks().Count());
        }

        [Fact]
        public void RegisterFeedBackShouldActuallyRegistersFeedback()
        {
            var options = new DbContextOptionsBuilder<BarberShopDbContext>()
                .UseInMemoryDatabase(databaseName: "Unique_Db_Name_6285923")
                .Options;
            var dbContext = new BarberShopDbContext(options);

            var feedbackRepository = new DbRepository<Contact>(dbContext);
            var homeService = new HomeService(feedbackRepository);

            homeService.RegisterFeedBack("Stanislav", "Mirchev", "stanislavv@domain.com", "mnenie");
            
            Assert.Equal(1, feedbackRepository.All().Count());
        }
    }
}
