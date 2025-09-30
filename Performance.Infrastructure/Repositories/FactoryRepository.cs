
using Microsoft.EntityFrameworkCore;
using Performance.Domain.IRepositories;
using Performance.Domain.Models;
using Performance.Infrastructure.DbContext;

namespace Performance.Infrastructure
{
    public class FactoryRepository : IFactoryRepository
    { 
        private readonly AppDbContext _context;
        public FactoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Factory factory)
        {
          await _context.Factories.AddAsync(factory); 
          await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        { 
            var factory = await _context.Factories.FindAsync(id); 
            if(factory == null) return;
            _context.Factories.Remove(factory);
            await  _context.SaveChangesAsync();
          
        }

        public async Task<IEnumerable<Factory>> GetAllAsync()
        {
            return await _context.Factories.ToListAsync();
        }


        public Task<Factory?> GetByIdAsync(int id)
        {
            return _context.Factories
                .Where(f => f.Id.ToString() == id.ToString())
                .FirstOrDefaultAsync();
        }

        public async Task<PagedResult<Factory>> GetPagedAsync(int pageNumber, int pageSize)
        {
            pageNumber = pageNumber <= 0 ? 1 : pageNumber;
            pageSize = pageSize <= 0 ? 10 : pageSize;

            var query = _context.Factories
                .AsNoTracking()
                .OrderBy(f => f.Id);

            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var count = await query.CountAsync();

            return new PagedResult<Factory>
            {
                Items = items,
                TotalCount = count,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }


        public async Task UpdateAsync(Factory factory)
        {
            var FactoryFromDb = await _context.Factories
                          .FirstOrDefaultAsync(
                                     f => f.Id.ToString() == factory.Id.ToString()
                                     );
            if (FactoryFromDb == null) return; 
            FactoryFromDb.NameAr = factory.NameAr; 
            FactoryFromDb.NameEn = factory.NameEn;

            FactoryFromDb.Specification = factory.Specification        ;
            FactoryFromDb.Location = factory.Location;
            FactoryFromDb.UpdatedAt = factory.UpdatedAt;
            FactoryFromDb.UpdatedBy = factory.UpdatedBy;

            await _context.SaveChangesAsync();
            //var Factory = _context.Factories.Attach(factory);

        }
    }
}
