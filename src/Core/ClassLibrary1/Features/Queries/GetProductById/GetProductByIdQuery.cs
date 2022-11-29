using MediatR;
using OnionPattern.Application.Dto;
using OnionPattern.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery :IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }
        public GetProductByIdQuery()
        {

        }
    }
}
