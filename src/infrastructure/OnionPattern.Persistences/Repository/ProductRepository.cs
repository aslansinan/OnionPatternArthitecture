using OnionPattern.Application.Interface.Repository;
using OnionPattern.Persistences.Context;
using OnionPatternDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Persistences.Repository
{
    internal class ProductRepository :GenericRepository<Product>,IProductRepository
    {

        public ProductRepository(ApplicationDbContext dbContext):base(dbContext)
        {
        }
    }
}
