using MediatR;
using OrderService.Application.Repositories.CustomerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.CustomerQuery.GetAllCustomer
{
    public class GettAllCustomerQueryHandler : IRequestHandler<GettAllCustomerQueryRequest, GettAllCustomerQueryResponse>
    {
        readonly ICustomerReadRepository _customerReadRepository;

        public GettAllCustomerQueryHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<GettAllCustomerQueryResponse> Handle(GettAllCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            var customers = _customerReadRepository.GetAll(false).ToList();
            return new()
            {
                customers = customers
            };
        }
    }
}
