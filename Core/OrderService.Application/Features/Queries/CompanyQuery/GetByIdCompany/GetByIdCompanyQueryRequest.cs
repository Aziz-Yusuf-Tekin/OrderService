using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.CompanyQuery.GetByIdCompany
{
    public class GetByIdCompanyQueryRequest : IRequest<GetByIdCompanyQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
