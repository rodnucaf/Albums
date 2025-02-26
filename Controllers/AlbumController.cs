using Albums.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Albums.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumContext _context;

        public AlbumController(AlbumContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var album = await _context.Albums.ToListAsync();


            return View(album);
        }
    }
}
