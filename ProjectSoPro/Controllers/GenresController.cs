using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectSoPro.Models;

namespace ProjectSoPro.Controllers
{
    public class GenresController : Controller
    {
        private readonly DataContext _context;

        public GenresController(DataContext context)
        {
            _context = context;
        }

        // GET: Genres
        public async Task<IActionResult> Index()
        {
            return RedirectToAction("Index", "Index", new { area = "" });
        }

     

        // GET: Genres/Create
        public IActionResult Create()
        {
            ViewData["genreId"] = new SelectList(_context.genre, "genreId", "genreId");
            ViewData["Movieid"] = new SelectList(_context.movie, "Movieid", "Title");
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieRolesId,genreId,Movieid")] MovieRoles movieRoles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieRoles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["genreId"] = new SelectList(_context.genre, "genreId", "genreId", movieRoles.genreId);
            ViewData["Movieid"] = new SelectList(_context.movie, "Movieid", "Title", movieRoles.Movieid);
            return View(movieRoles);
        }


        private bool MovieRolesExists(int id)
        {
          return (_context.movieRoles?.Any(e => e.MovieRolesId == id)).GetValueOrDefault();
        }
    }
}
