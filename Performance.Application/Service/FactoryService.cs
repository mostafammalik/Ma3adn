using Performance.Domain.Models;
using Performance.Application.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Performance.Domain.IRepositories;

namespace Performance.Application.Service
{
    public class FactoryService : IFactoryService
    { 
        private readonly IFactoryRepository _factoryRepository ;
        public FactoryService (IFactoryRepository factoryRepository)
        {
           this._factoryRepository = factoryRepository;
        }
        public Task AddAsync(Factory factory)
        {
           return _factoryRepository.AddAsync(factory);
        }

        public Task DeleteAsync(int id)
        {
           return _factoryRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Factory>> GetAllAsync()
        {
           return _factoryRepository.GetAllAsync();
        }

        public Task<Factory?> GetByIdAsync(int id)
        {
           return _factoryRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<Factory>> GetPagedAsync(int pageNumber, int pageSize)
        {
           return _factoryRepository
                  .GetPagedAsync(pageNumber, pageSize)
                  .ContinueWith(t => t.Result.Items);
        }

        public Task UpdateAsync(Factory factory)
        {
            return _factoryRepository.UpdateAsync(factory);
        }
    }
}
