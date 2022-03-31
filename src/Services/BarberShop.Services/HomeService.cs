using BarberShop.Data.Common.Repositories;
using BarberShop.Data.Models;
using BarberShop.Services.Contracts;
using System;
using System.Collections.Generic;

namespace BarberShop.Services
{
    public class HomeService : IHomeService
    {
        private readonly IRepository<Contact> feedbackRepository;

        public HomeService(IRepository<Contact> feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }

        public IEnumerable<Contact> AllFeedbacks() => this.feedbackRepository.All();

        public void RegisterFeedBack(string firstName, string lastName, string email, string message)
        {
            var info = new Contact()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = email,
                Message = message
            };

             this.feedbackRepository.Add(info);
             this.feedbackRepository.SaveChanges();
        }
    }
}
