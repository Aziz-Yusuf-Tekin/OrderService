using MediatR;
using OrderService.Application.Repositories.OrderRepository;
using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.OrderQuery.GetByIdOrder
{
    public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQueryRequest, GetByIdOrderQueryResponse>
    {
        readonly IOrderReadRepository _orderReadRepository;

        public GetByIdOrderQueryHandler(IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<GetByIdOrderQueryResponse> Handle(GetByIdOrderQueryRequest request, CancellationToken cancellationToken)
        {
            Order order = await _orderReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                CustomerId = order.CustomerId,
                ProductId = order.ProductId,
            };
        }
    }
}
