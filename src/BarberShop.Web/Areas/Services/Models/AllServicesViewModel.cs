using AutoMapper;
using BarberShop.Data.Models;
using BarberShop.Services.Mapping;

namespace BarberShop.Web.Areas.Services.Models
{
    public class AllServicesViewModel : IMapFrom<Service>, IHaveCustomMappings
    {
        public string Id { get; set; }
        public string ImageUrl { get; set; }    
        public string Description { get; set; }     
        public string Name { get; set; }    
        public decimal Price { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Service, AllServicesViewModel>()
                .ForMember(x => x.Id, m => m.MapFrom(s => s.Id));   
        }
    }
}
