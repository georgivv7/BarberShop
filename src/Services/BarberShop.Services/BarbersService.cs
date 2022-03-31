namespace BarberShop.Services
{
    using BarberShop.Data.Common.Repositories;
    using BarberShop.Data.Models;
    using BarberShop.Data.Models.Enums;
    using BarberShop.Services.Contracts;
    using BarberShop.Services.Mapping;
    using System;
    using System.Globalization;
    using System.Linq;

    public class BarbersService : IBarbersService
    {
        private readonly IRepository<Barber> barberRepository;
        private readonly IRepository<Appointment> appointmentRepository;
        private readonly IRepository<Service> stylesRepository;

        public BarbersService(IRepository<Barber> barberRepository,
                             IRepository<Appointment> appointmentRepository,
                             IRepository<Service> stylesRepository)
        {
            this.barberRepository = barberRepository;
            this.appointmentRepository = appointmentRepository;
            this.stylesRepository = stylesRepository;
        }

        public IQueryable<Barber> All() => this.barberRepository.All();    

        public TViewModel Details<TViewModel>(string id)
        {
            var barber = this.barberRepository.All()
                .Where(b => b.Id == id)
                .To<TViewModel>()
                .FirstOrDefault();

            return barber;
        }

        public bool AddAppointment(string bookedFor, string description, 
                                               string barberServiceName, string userId, string barberId)
        {
            if (bookedFor == null ||
                description == null ||
                barberServiceName == null ||
                userId == null ||
                barberId == null)
            {
                return false;
            }

            var barber = this.barberRepository.All().FirstOrDefault(b=>b.Id == barberId);

            var hairAndBeardStyle = Enum.Parse<HairAndBeardStyles>(barberServiceName);

            var barberService = this.stylesRepository.All().FirstOrDefault(s=>s.Name == hairAndBeardStyle);

            var BookedFor = DateTime.ParseExact(bookedFor, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            if (DateTime.UtcNow > BookedFor)
            {
                return false;
            }

            var appointment = new Appointment
            {

                Id = Guid.NewGuid().ToString(),
                UserId = userId,
                BarberId = barberId,
                BookedOn = DateTime.UtcNow,
                BookedFor = BookedFor,
                BarberService = barberService,
                Description = description,
            };

            this.appointmentRepository.Add(appointment);
            this.appointmentRepository.SaveChanges();

            return true;
        }
    }
}
