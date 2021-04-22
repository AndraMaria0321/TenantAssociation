using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TenantsAss.DataAccess;
using TenantsAss.DataModel;

namespace TenantsAss.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly TenantsAssDbContext _context;

        public ApartmentController(TenantsAssDbContext context)
        {
            _context = context;
        }

        // GET: Apartment
        public async Task<IActionResult> Index()
        {
            var tenantsAssDbContext = _context.Apartment.Include(a => a.Building).Include(a => a.User);
            return View(await tenantsAssDbContext.ToListAsync());
        }

        // GET: Apartment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apartment = await _context.Apartment
                .Include(a => a.Building)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.ApartmenTId == id);
            if (apartment == null)
            {
                return NotFound();
            }

            return View(apartment);
        }

        // GET: Apartment/Create
        public IActionResult Create()
        {
            ViewData["BuildingId"] = new SelectList(_context.Building, "BuildingId", "BuildingId");
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId");
            return View();
        }

        // POST: Apartment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApartmenTId,ApartmentNo,UserId,FirstName,LastName,BuildingId,BuildingNo")] Apartment apartment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(apartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BuildingId"] = new SelectList(_context.Building, "BuildingId", "BuildingId", apartment.BuildingId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", apartment.UserId);
            return View(apartment);
        }

        // GET: Apartment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apartment = await _context.Apartment.FindAsync(id);
            if (apartment == null)
            {
                return NotFound();
            }
            ViewData["BuildingId"] = new SelectList(_context.Building, "BuildingId", "BuildingId", apartment.BuildingId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", apartment.UserId);
            return View(apartment);
        }

        // POST: Apartment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApartmenTId,ApartmentNo,UserId,FirstName,LastName,BuildingId,BuildingNo")] Apartment apartment)
        {
            if (id != apartment.ApartmenTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(apartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApartmentExists(apartment.ApartmenTId))
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
            ViewData["BuildingId"] = new SelectList(_context.Building, "BuildingId", "BuildingId", apartment.BuildingId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", apartment.UserId);
            return View(apartment);
        }

        // GET: Apartment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apartment = await _context.Apartment
                .Include(a => a.Building)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.ApartmenTId == id);
            if (apartment == null)
            {
                return NotFound();
            }

            return View(apartment);
        }

        // POST: Apartment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var apartment = await _context.Apartment.FindAsync(id);
            _context.Apartment.Remove(apartment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApartmentExists(int id)
        {
            return _context.Apartment.Any(e => e.ApartmenTId == id);
        }
    }
}
