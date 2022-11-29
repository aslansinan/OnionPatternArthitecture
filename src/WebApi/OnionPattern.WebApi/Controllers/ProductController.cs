using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionPattern.Application.Dto;
using OnionPattern.Application.Features.Commands.CreateProductCommand;
using OnionPattern.Application.Features.Queries.GetAllProducts;
using OnionPattern.Application.Features.Queries.GetProductById;
using OnionPattern.Application.Interface.Repository;

namespace OnionPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id=id};
            return Ok(await mediator.Send(query));
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }

    }
}
