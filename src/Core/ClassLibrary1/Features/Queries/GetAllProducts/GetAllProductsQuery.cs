using MediatR;
using OnionPattern.Application.Dto;
using OnionPattern.Application.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery :IRequest<List<ProductViewDto>> 
    {
       
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductViewDto>>
        {
            private readonly IProductRepository productRepostiory;

            public GetAllProductsQueryHandler(IProductRepository productRepostiory)
            {
                this.productRepostiory = productRepostiory;
            }
            public async Task<List<ProductViewDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await productRepostiory.GetAllAsync();
                return products.Select(x => new ProductViewDto()
                {
                    Id = x.id,
                    Name = x.Name
                }).ToList();
            }
        }
    }
}
