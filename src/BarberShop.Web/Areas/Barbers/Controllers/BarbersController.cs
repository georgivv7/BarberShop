using BarberShop.Services.Contracts;
using BarberShop.Services.Mapping;
using BarberShop.Web.Areas.Barbers.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System.Linq;
using System.Security.Claims;

namespace BarberShop.Web.Areas.Barbers.Controllers
{
    [Area("Barbers")]
    public class BarbersController : Controller
    {
        private readonly IBarbersService barberService;
        private readonly IBarberServicesService barberServicesService;
        private readonly IUserService userService;

        public BarbersController(IBarbersService barberService,
                                 IBarberServicesService barberServicesService,
                                 IUserService userService)
        {
            this.barberService = barberService;
            this.barberServicesService = barberServicesService;
            this.userService = userService;
        }
        public IActionResult All()
        {
            var barbers = this.barberService.All()
                .To<DisplayAllBarbersViewModel>()
                .ToList();

            return View(barbers);
        }
        public IActionResult Details(string id)
        {
            var barber = this.barberService.Details<DisplayBarberDetailsViewModel>(id);
            return View(barber);
        }

        [Authorize]
        public IActionResult Appointment()
        {
            this.ViewData["BarberStyles"] = this.barberServicesService.All()
                .Select(ts => new SelectListItem
                {
                    Value = ts.Id.ToString(),
                    Text = ts.Name.ToString()
                });

            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Appointment(AppointmentInputViewModel model)   
        {
            if (!TryValidateModel(model))
            {
                this.ViewData["BarberStyles"] = this.barberServicesService.All()
                .Select(ts => new SelectListItem
                {
                    Value = ts.Id.ToString(),
                    Text = ts.Name.ToString()
                });

                return this.View();
            }

            var barber = this.barberService.All().SingleOrDefault(b=>b.FirstName == model.BarberName);

            var barberServiceName = this.barberServicesService.GetService(model.BarberServiceName).Name.ToString();

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var bookSuccessful = this.barberService.AddAppointment(model.BookedFor, model.Description,
                                                                   barberServiceName, userId, barber.Id);

            if (!bookSuccessful)
            {
                this.ViewData["BarberStyles"] = this.barberServicesService.All()
                .Select(ts => new SelectListItem
                {
                    Value = ts.Id.ToString(),
                    Text = ts.Name.ToString()
                });

                return this.View();
            }

            var successDto = this.barberService
                .Details<BooksSuccesfullViewModel>(barber.Id);
            var userEmail = this.userService.GetUserEmail(userId);
            successDto.BookedFor = model.BookedFor;
            successDto.Email = userEmail;

            return this.View("BookSuccessful", successDto);
        }
    }
}
