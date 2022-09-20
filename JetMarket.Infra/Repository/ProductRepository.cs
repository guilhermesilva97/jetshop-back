
using Dapper;
using JetMarket.Domain.Interface.Repository;
using JetMarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace JetMarket.Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _dbConnection;
        public ProductRepository(IDbConnection dbConnection)
        => _dbConnection = dbConnection;
        public async Task<bool> Delete(Guid id)
        {
            const string sql = "DELETE FROM Product WHERE Product.Id = @ProductID";

            try
            {
                await _dbConnection.ExecuteAsync(sql, new { ProductID = id });

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Product> Get(Guid id)
        {
            const string sql = "SELECT * FROM Product WHERE Product.Id = @ProductID";

            try
            {
                return await _dbConnection.QueryFirstOrDefaultAsync<Product>(sql, new { ProductID = id });
            }
            catch
            {
                return null;
            }

        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            const string sql = "SELECT * FROM Product ORDER BY Name";

            try
            {
                return await _dbConnection.QueryAsync<Product>(sql);
            }
            catch
            {
                return null;
            }
            
        }

        public async Task<Product> Insert(Product entity)
        {
            const string sql = "" +
            "INSERT INTO Product VALUES " +
            "(@IdProduct," +
            "@NameProduct," +
            "@ImageProduct," +
            "@DescriptionProduct," +
            "@StockProduct," +
            "@StatusProduct," +
            "@PriceProduct)";
            try
            {
                await _dbConnection.ExecuteAsync(sql, new
                {
                    IdProduct = entity.Id,
                    NameProduct = entity.Name,
                    DescriptionProduct = entity.Description,
                    ImageProduct = entity.Image,
                    StockProduct = entity.Stock,
                    StatusProduct = entity.Status,
                    PriceProduct = entity.Price
                });

                return entity;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Product> Update(Product entity)
        {
            const string sql = "" +
            "UPDATE Product SET " +
            "name = @NameProduct," +
            "image = @ImageProduct," +
            "description = @DescriptionProduct," +
            "stock = @StockProduct," +
            "status = @StatusProduct," +
            "price = @PriceProduct " +
            "WHERE id = @IdProduct";
            try
            {
                await _dbConnection.ExecuteAsync(sql, new
                {
                    IdProduct = entity.Id,
                    NameProduct = entity.Name,
                    DescriptionProduct = entity.Description,
                    ImageProduct = entity.Image,
                    StockProduct = entity.Stock,
                    StatusProduct = entity.Status,
                    PriceProduct = entity.Price
                });

                return entity;
            }
            catch
            {
                return null;
            }
        }
    }
}
