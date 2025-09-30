
using Performance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Domain.IRepositories
{
    public class PagedResult<T>
    {
        public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public interface IFactoryRepository
    {
        Task<Factory?> GetByIdAsync(int id);
        Task<IEnumerable<Factory>> GetAllAsync();
        Task<PagedResult<Factory>> GetPagedAsync(int pageNumber, int pageSize);
        Task AddAsync(Factory factory);
        Task UpdateAsync(Factory factory);
        Task DeleteAsync(int id);
    }

}
