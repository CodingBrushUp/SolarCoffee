using SolarCoffee.Common.Helpers;
using SolarCoffee.Data.Models;
using SolarCoffee.Repository.Contracts;
using SolarCoffee.Repository.Models;

namespace SolarCoffee.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        public virtual PagedList<Product> GetProducts(CustomerParameters parameters)
        {
            var products = _repository.TableNoTracking;
            return PagedList<Product>.ToPagedList(products,
                parameters.PageNumber,
                parameters.PageSize);
        }
    }
}