using System.Text.Json;
using Eshop.Domain;

namespace Ehop.DAL
{
    public class JsonProductRepository //: IProductRepository
    {
        public IEnumerable<Product> Get()
        {

            var json = File.ReadAllText("Products.json");
            var products = JsonSerializer.Deserialize<Product[]>(json);

            return products;
        }

    }
}
