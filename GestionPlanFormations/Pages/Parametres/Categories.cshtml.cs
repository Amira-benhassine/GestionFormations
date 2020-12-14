using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestionPlanFormations.Data;
using GestionPlanFormations.Models;

namespace GestionPlanFormations.Pages.Parametres
{
    public class CategoriesModel : PageModel
    {
        private readonly GestionPlanFormations.Data.GestionPlanFormationsContext _context;

        public CategoriesModel(GestionPlanFormations.Data.GestionPlanFormationsContext context)
        {
            _context = context;
        }

        public IList<Categorie> Categorie { get;set; }

        public async Task OnGetAsync()
        {
            Categorie = await _context.Categorie.ToListAsync();
        }
    }
}
