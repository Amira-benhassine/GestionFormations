using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionPlanFormations.Data;
using GestionPlanFormations.Models;

namespace GestionPlanFormations.Pages.Parametres
{
    public class EditModel : PageModel
    {
        private readonly GestionPlanFormations.Data.GestionPlanFormationsContext _context;

        public EditModel(GestionPlanFormations.Data.GestionPlanFormationsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Categorie Categorie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Categorie = await _context.Categorie.FirstOrDefaultAsync(m => m.Id == id);

            if (Categorie == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Categorie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorieExists(Categorie.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CategorieExists(int id)
        {
            return _context.Categorie.Any(e => e.Id == id);
        }
    }
}
