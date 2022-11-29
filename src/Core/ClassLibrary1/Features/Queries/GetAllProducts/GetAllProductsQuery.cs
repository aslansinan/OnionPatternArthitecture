using AutoMapper;
using MediatR;
using OnionPattern.Application.Dto;
using OnionPattern.Application.Interface.Repository;
using OnionPattern.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery :IRequest<ServiceResponse<List<ProductViewDto>>> 
    {
       
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
        {
            private readonly IProductRepository productRepostiory;
            private readonly IMapper mapper;

            public GetAllProductsQueryHandler(IProductRepository productRepostiory,IMapper mapper)
            {
                this.productRepostiory = productRepostiory;
                this.mapper = mapper;
            }
            public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await productRepostiory.GetAllAsync();
                var viewModel =mapper.Map<List<ProductViewDto>>(products);
                return new ServiceResponse<List<ProductViewDto>>(viewModel);
            }
        }
    }
}
