using BarberShop.Data.Common.Repositories;
using BarberShop.Data.Models;
using BarberShop.Data.Models.Enums;
using BarberShop.Services.Contracts;
using System;
using System.Linq;

namespace BarberShop.Services
{
    public class BarberServicesService : IBarberServicesService
    {
        private readonly IRepository<Service> serviceRepository;

        public BarberServicesService(IRepository<Service> serviceRepository)
        {
            this.serviceRepository = serviceRepository;
        }
        public IQueryable<Service> All()
        {
            var services = this.serviceRepository.All();

            return services;
        }

        public Service GetService(string serviceId)
        {
            var service = this.serviceRepository.All().SingleOrDefault(s => s.Id == serviceId);

            return service;
        }
    }
}
