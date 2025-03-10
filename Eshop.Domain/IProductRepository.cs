using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;

namespace Eshop.Domain
{
    public interface IProductRepository
    {
        public Task<Result<IEnumerable<Product>>> Get();
    }
}
