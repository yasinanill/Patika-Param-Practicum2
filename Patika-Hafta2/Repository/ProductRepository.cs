using Microsoft.EntityFrameworkCore;
using Patika_Hafta1_Odev.Data;
using Patika_Hafta1_Odev.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patika_Hafta1_Odev.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var removeEntity = await _context.Products.FindAsync(id);
            _context.Products.Remove(removeEntity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            var unchangedEntity = await _context.Products.FindAsync(product.Id);

            _context.Entry(unchangedEntity).CurrentValues.SetValues(product);

            await _context.SaveChangesAsync();

        }
    }
}
