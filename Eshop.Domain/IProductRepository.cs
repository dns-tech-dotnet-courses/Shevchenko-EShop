using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain
{
    public interface IProductRepository
    {
        public IEnumerable<Product> Get();
        public int GetProductsCount();
    }
}
