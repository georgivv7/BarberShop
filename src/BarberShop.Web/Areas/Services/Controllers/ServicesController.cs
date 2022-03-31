using BarberShop.Services.Contracts;
using BarberShop.Services.Mapping;
using BarberShop.Web.Areas.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BarberShop.Web.Areas.Services.Controllers
{
    [Area("Services")]
    public class ServicesController : Controller
    {
        private readonly IBarberServicesService barbersService;

        public ServicesController(IBarberServicesService barbersService)
        {
            this.barbersService = barbersService;
        }
        public IActionResult All()  
        {
            var services = this.barbersService.All()
                .To<AllServicesViewModel>()
                .ToList();

            return View(services);
   
        }
    }
}
