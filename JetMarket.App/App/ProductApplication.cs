using JetMarket.App.Interface;
using JetMarket.Domain.Interface.Repository;
using JetMarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JetMarket.App.App
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _repository;
        public ProductApplication(IProductRepository repository)
               => _repository = repository;

        public async Task<bool> Delete(Guid id)
        {
            var response = false;

            var product = await _repository.Get(id);

            if (product != null)
            {
                response = await _repository.Delete(id);
            }

            return response;
        }

        public async Task<Product> Get(Guid id)
        {
            return await _repository.Get(id);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<Product> Insert(Product entity)
        {
            entity.Id = Guid.NewGuid();

            return await _repository.Insert(entity);
        }

        public async Task<Product> Update(Product entity)
        {
            var product = await Get(entity.Id);

            if (product != null)
            {
                return await _repository.Update(entity);
            }

            return null;
        }
    }
}
