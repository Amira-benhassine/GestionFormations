using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestionPlanFormations.Models;

namespace GestionPlanFormations.Data
{
    public class GestionPlanFormationsContext : DbContext
    {
        public GestionPlanFormationsContext (DbContextOptions<GestionPlanFormationsContext> options)
            : base(options)
        {
        }

        public DbSet<GestionPlanFormations.Models.Categorie> Categorie { get; set; }
    }
}
