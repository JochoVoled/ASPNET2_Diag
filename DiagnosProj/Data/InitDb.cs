using DiagnosProj.Models;

namespace DiagnosProj.Data
{
    public class InitDb
    {

        private readonly ApplicationDbContext _context;

        public InitDb(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Init()
        {
            /* TODO - Prepopulera ProductCategories med tre kategorier: "TV", "DVD" och "VHS". */
            _context.ProductCategories.AddRange(new ProductCategory
            {
                Name = "TV"
            }, new ProductCategory
            {
                Name = "DVD"
            }, new ProductCategory
            {
                Name = "VHS"
            });
            _context.SaveChanges();
        }
    }
}
