using AutoMapper;
using BarberShop.Data.Models;
using BarberShop.Services.Mapping;

namespace BarberShop.Web.Areas.Barbers.Models
{
    public class DisplayBarberDetailsViewModel : IMapFrom<Barber>, IHaveCustomMappings
    {
        public string BarberId { get; set; }    
        public string ImageUrl { get; set; }    
        public string FirstName { get; set; }    
        public string LastName { get; set; }     
        public string Biography { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Barber, DisplayBarberDetailsViewModel>()
                .ForMember(x => x.BarberId, m => m.MapFrom(b => b.Id));
        }
    }
}
