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
    public class IndexController : Controller
    {
        private readonly DataContext _context;

        public IndexController(DataContext context)
        {
            _context = context;
        }

        // GET: Index
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.movieRoles.Include(b => b.Genre).Include(b => b.Movie).OrderByDescending(p => p.Movieid);
            return View(await dataContext.ToListAsync());
        }

        // GET: Index/Details/5

        public async Task<IActionResult> Details(int? id)
        {

            var FindDetails = from b in _context.roles select b;
            if (id != null)
            {
                FindDetails = FindDetails
                    .Include(b => b.Movie)
                    .Include(b => b.Person)
                    .Where(b => b.Movieid.Equals(id));
            }
            else
            {
                return NotFound();
            }

            return View(FindDetails);
        }


        // GET: Index/Create
        public IActionResult Create()
        {
            ViewData["Movieid"] = new SelectList(_context.movie, "Movieid", "Title");
            ViewData["Personid"] = new SelectList(_context.person, "Personid", "name");
            return View();
        }

        // POST: Index/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RolesId,actors,directors,producers,Movieid,Personid")] PersonRoles personRoles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personRoles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Movieid"] = new SelectList(_context.movie, "Movieid", "Title", personRoles.Movieid);
            ViewData["Personid"] = new SelectList(_context.person, "Personid", "name", personRoles.Personid);
            return View(personRoles);
        }

        // GET: Index/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.roles == null)
            {
                return NotFound();
            }

            var personRoles = await _context.roles.FindAsync(id);
            if (personRoles == null)
            {
                return NotFound();
            }
            ViewData["Movieid"] = new SelectList(_context.movie, "Movieid", "Movieid", personRoles.Movieid);
            ViewData["Personid"] = new SelectList(_context.person, "Personid", "email", personRoles.Personid);
            return View(personRoles);
        }

        // POST: Index/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RolesId,actors,directors,producers,Movieid,Personid")] PersonRoles personRoles)
        {
            if (id != personRoles.RolesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personRoles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonRolesExists(personRoles.RolesId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Movieid"] = new SelectList(_context.movie, "Movieid", "Movieid", personRoles.Movieid);
            ViewData["Personid"] = new SelectList(_context.person, "Personid", "email", personRoles.Personid);
            return View(personRoles);
        }

        // GET: Index/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.roles == null)
            {
                return NotFound();
            }

            var personRoles = await _context.roles
                .Include(p => p.Movie)
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.RolesId == id);
            if (personRoles == null)
            {
                return NotFound();
            }

            return View(personRoles);
        }

        // POST: Index/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.roles == null)
            {
                return Problem("Entity set 'DataContext.roles'  is null.");
            }
            var personRoles = await _context.roles.FindAsync(id);
            if (personRoles != null)
            {
                _context.roles.Remove(personRoles);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonRolesExists(int id)
        {
          return (_context.roles?.Any(e => e.RolesId == id)).GetValueOrDefault();
        }
    }
}
