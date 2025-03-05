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
            var album = await _context.Albums.Include(g=>g.GenreName).ToListAsync();


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
                return RedirectToAction("index");
            }
            return View(album);
        }

        public async Task<IActionResult> Edit(int id)
        { 
            var album = await _context.Albums.FirstOrDefaultAsync(a => a.Id == id);
            return View(album);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, Date")] Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Update(album);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(album);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var album = await _context.Albums.FirstOrDefaultAsync(a => a.Id == id);
            return View(album);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var album = await _context.Albums.FindAsync(id);
            if (album is not null)
            {
                _context.Albums.Remove(album);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
