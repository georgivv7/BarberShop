using AutoMapper;
using BarberShop.Data.Common;
using BarberShop.Data.Models;
using BarberShop.Services.Mapping;
using System.ComponentModel.DataAnnotations;

namespace BarberShop.Web.Areas.Barbers.Models
{
    public class BooksSuccesfullViewModel : IMapFrom<Barber>, IHaveCustomMappings
    {
        [Required(ErrorMessage = GlobalConstants.BookedForError)]
        public string BookedFor { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Barber, BooksSuccesfullViewModel>()
                 .ForMember(x => x.FirstName, m => m.MapFrom(p => p.FirstName));

            configuration.CreateMap<Barber, BooksSuccesfullViewModel>()
                .ForMember(x => x.LastName, m => m.MapFrom(p => p.LastName));
        }
    }
}
