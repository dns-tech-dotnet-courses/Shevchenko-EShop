using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Eshop.Domain;

namespace Ehop.DAL
{
    public class NewJsonProductRepository : IProductRepository
    {

        public IEnumerable<Product> GetFromNewJson()
        {
            var json = File.ReadAllText("NewJsonProducts.json");
            var products = JsonSerializer.Deserialize<Product[]>(json);

            return products;

        }
    }
}
