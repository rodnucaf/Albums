using Microsoft.AspNetCore.Mvc;

namespace Albums.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
