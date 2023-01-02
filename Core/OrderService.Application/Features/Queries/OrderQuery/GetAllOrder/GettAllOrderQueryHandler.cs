using MediatR;
using OrderService.Application.Repositories.OrderRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.OrderQuery.GetAllOrder
{
    public class GettAllOrderQueryHandler : IRequestHandler<GettAllOrderQueryRequest, GettAllOrderQueryResponse>
    {
        readonly IOrderReadRepository _orderReadRepository;

        public GettAllOrderQueryHandler(IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<GettAllOrderQueryResponse> Handle(GettAllOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var orders = _orderReadRepository.GetAll(false).ToList();
            return new()
            {
                orders = orders
            };
        }
    }
}
