using AutoMapper;
using BarberShop.Data.Common;
using BarberShop.Data.Models;
using BarberShop.Services.Mapping;
using System.ComponentModel.DataAnnotations;

namespace BarberShop.Web.Areas.Barbers.Models
{
    public class AppointmentInputViewModel : IMapFrom<Appointment>, IHaveCustomMappings
    {      
        [Required]
        public string BarberName { get; set; }    
        
        [Required]
        public string BarberServiceName { get; set; }

        [Required(ErrorMessage = GlobalConstants.BookedForError)]
        public string BookedFor { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Appointment,AppointmentInputViewModel>()
                .ForMember(x=>x.BarberName, m=>m.MapFrom(a=>a.Barber.FirstName));
        }
    }
}
