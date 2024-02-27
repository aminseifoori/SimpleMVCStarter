using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PassengerController : Controller
    {
        private readonly IPassangerRepository passangerRepository;

        public PassengerController(IPassangerRepository _passangerRepository)
        {
            passangerRepository = _passangerRepository;
        }
        public IActionResult Index()
        {
            var passes = passangerRepository.GetAll();
            return View(passes);
        }
    }
}
