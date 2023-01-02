using MediatR;
using OrderService.Application.Repositories.OrderRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.OrderCommand.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        readonly IOrderWriteRepository _orderWriteRepository;

        public CreateOrderCommandHandler(IOrderWriteRepository orderWriteRepository)
        {
            _orderWriteRepository = orderWriteRepository;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            await _orderWriteRepository.AddAsync(new()
            {
                CustomerId = request.CustomerId,
                ProductId = request.ProductId,
                OrderTime = request.OrderTime,
                ApprovalStatus = request.ApprovalStatus,
            });
            await _orderWriteRepository.SaveAsync();
            return new();
        }
    }
}
