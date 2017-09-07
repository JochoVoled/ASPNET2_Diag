using DiagnosProj.Models;

namespace DiagnosProj.Data
{
    public static class InitDb
    {

        //private readonly ApplicationDbContext _context;

        //public InitDb(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public static void Init(ApplicationDbContext context)
        {
            /* TODO - Prepopulera ProductCategories med tre kategorier: "TV", "DVD" och "VHS". */
            context.ProductCategories.AddRange(
                new ProductCategory{ Name = "TV"  },
                new ProductCategory{ Name = "DVD" },
                new ProductCategory{ Name = "VHS" });
            context.SaveChanges();
        }
    }
}
