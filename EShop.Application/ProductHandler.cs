using System.Text.Json;
using Ehop.DAL;
using Eshop.Domain;

namespace EShop.Application
{
    public class ProductHandler
    {
        private readonly IProductRepository _productRepository;

        public ProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Get()
        {
            var products = _productRepository.Get();
            return products;
        }

        public IEnumerable<Product> GetById(int id)
        {
            var products = _productRepository.Get();
            return products.Where(product => product.Id == id);
        }

        
        public IEnumerable<Product> GetByName(string name)
        {
            var products = _productRepository.Get();

            if (!string.IsNullOrEmpty(name))
                products = products.Where(p => p.Name == name);

            return products;
              
        }
    }
}
