using SolarCoffee.Common.Helpers;
using SolarCoffee.Data.Models;
using SolarCoffee.Repository.Models;

namespace SolarCoffee.Services
{
    public interface IProductService
    {
        PagedList<Product> GetProducts(CustomerParameters parameters);
    }
}