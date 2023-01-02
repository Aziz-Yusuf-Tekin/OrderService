using MediatR;
using OrderService.Application.Repositories.CompanyRepository;
using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.CompanyQuery.GetByIdCompany
{
    public class GetByIdCompanyQueryHandler : IRequestHandler<GetByIdCompanyQueryRequest, GetByIdCompanyQueryResponse>
    {
        readonly ICompanyReadRepository _companyReadRepository;

        public GetByIdCompanyQueryHandler(ICompanyReadRepository companyReadRepository)
        {
            _companyReadRepository = companyReadRepository;
        }

        public async Task<GetByIdCompanyQueryResponse> Handle(GetByIdCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            Company company = await _companyReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Name = company.Name,
                OrderStartTime = company.OrderStartTime,
                OrderEndTime = company.OrderEndTime,
            };
        }
    }
}
