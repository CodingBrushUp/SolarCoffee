using SolarCoffee.Data.Models;
using SolarCoffee.Data.Repositories;
using SolarCoffee.Repository.Contracts;

namespace SolarCoffee.Repository.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
