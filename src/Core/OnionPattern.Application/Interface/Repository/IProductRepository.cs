using OnionPatternDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Application.Interface.Repository
{
    public interface  IProductRepository :IGenericRepositoryAsync<Product>
    {
    }
}
