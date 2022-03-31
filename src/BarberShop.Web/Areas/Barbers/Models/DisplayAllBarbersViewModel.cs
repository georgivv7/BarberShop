using AutoMapper;
using BarberShop.Data.Models;
using BarberShop.Services.Mapping;

namespace BarberShop.Web.Areas.Barbers.Models
{
    public class DisplayAllBarbersViewModel : IMapFrom<Barber>, IHaveCustomMappings
    {
        public string ImageUrl { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }   
        public string  BarberId { get; set; }   
        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Barber,DisplayAllBarbersViewModel>()
                .ForMember(x=>x.BarberId,m=>m.MapFrom(a=>a.Id));
        }
    }
}
