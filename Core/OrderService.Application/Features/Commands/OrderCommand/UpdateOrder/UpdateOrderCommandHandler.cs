using MediatR;
using OrderService.Application.Repositories.OrderRepository;
using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.OrderCommand.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        readonly IOrderWriteRepository _orderWriteRepository;
        readonly IOrderReadRepository _orderReadRepository;

        public UpdateOrderCommandHandler(IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            Order order = await _orderReadRepository.GetByIdAsync(request.Id);
            order.ProductId = request.ProductId;
            order.CustomerId = request.CustomerId;
            order.ApprovalStatus = request.ApprovalStatus;
            order.OrderTime = request.OrderTime;
            await _orderWriteRepository.SaveAsync();
            return new();
        }
    }
}
