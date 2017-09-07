using DiagnosProj.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DiagnosProj.Services
{
    public class ProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList GetSelectList()
        {
            return new SelectList(_context.ProductCategories, "ProductCategoryId", "Name");
        }
    }
}
