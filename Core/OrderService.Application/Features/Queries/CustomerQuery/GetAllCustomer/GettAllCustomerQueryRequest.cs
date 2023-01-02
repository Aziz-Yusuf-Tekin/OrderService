using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.CustomerQuery.GetAllCustomer
{
    public class GettAllCustomerQueryRequest : IRequest<GettAllCustomerQueryResponse>
    {
    }
}
