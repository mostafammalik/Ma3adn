using Performance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Application.IServices
{
    public interface IFactoryService
    {
        Task<Factory?> GetByIdAsync(int id);
        Task<IEnumerable<Factory>> GetAllAsync(); 
        Task<IEnumerable<Factory>> GetPagedAsync(int pageNumber, int pageSize);
        Task AddAsync(Factory factory);
        Task UpdateAsync(Factory factory);
        Task DeleteAsync(int id);
    }
}
