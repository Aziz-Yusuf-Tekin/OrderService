using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.ProductCommand.CreateProduct
{
    public class CreateProductCommandRequest :IRequest<CreateProductCommandResponse>
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
    }
}
