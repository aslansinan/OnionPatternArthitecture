using AutoMapper;
using MediatR;
using OnionPattern.Application.Interface.Repository;
using OnionPattern.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Application.Features.Commands.CreateProductCommand
{
    public class CreateProductCommand :IRequest<ServiceResponse<Guid>>
    {
        public String Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
        {
            IProductRepository productRepository;
            private readonly IMapper mapper;

            public CreateProductCommandHandler(IProductRepository productRepository,IMapper mapper)
            {
                this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
                this.mapper = mapper;
            }
            public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var product = mapper.Map<OnionPatternDomain.Entities.Product>(request);
                await productRepository.AddAsync(product);
                return new ServiceResponse<Guid>(product.id);
            }
                
        }
    }
}
