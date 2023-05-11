using Microsoft.AspNetCore.Mvc;

namespace To_Do.Controllers
{
    public class TarefasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
