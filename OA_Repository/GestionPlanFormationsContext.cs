using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OA_DataAccess;

namespace OA_Repository
{
    public class GestionPlanFormationsContext : DbContext
    {
        public GestionPlanFormationsContext (DbContextOptions<GestionPlanFormationsContext> options)
            : base(options)
        {
        }

        public DbSet<Categorie> Categorie { get; set; }
    }
}
