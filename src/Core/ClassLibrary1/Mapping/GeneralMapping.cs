using AutoMapper;
using OnionPattern.Application.Features.Commands.CreateProductCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Application.Mapping
{
    public class GeneralMapping :Profile
    {
        public GeneralMapping()
        {
            CreateMap<OnionPatternDomain.Entities.Product, Dto.ProductViewDto>()
                .ReverseMap();

            CreateMap<OnionPatternDomain.Entities.Product, CreateProductCommand>()
                .ReverseMap();
        }
    }
}
