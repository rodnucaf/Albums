using Albums.Data;
using Albums.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Albums.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly AlbumContext _context;

        public AlbumsController(AlbumContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var album = await _context.Albums.ToListAsync();


            return View(album);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id, Name, Date")] Album album) 
        {
            if (ModelState.IsValid)
            {
                _context.Albums.Add(album);
                await _context.SaveChangesAsync();
                return View(RedirectToAction("index"));
            }
            return View(album);
        }


    }
}
