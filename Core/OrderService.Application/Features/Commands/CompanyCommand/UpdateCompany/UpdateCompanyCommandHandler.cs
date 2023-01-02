using MediatR;
using OrderService.Application.Repositories.CompanyRepository;
using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.CompanyCommand.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommandRequest, UpdateCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;
        readonly ICompanyReadRepository _companyReadRepository;

        public UpdateCompanyCommandHandler(ICompanyReadRepository productReadRepository, ICompanyWriteRepository productWriteRepository)
        {
            _companyReadRepository = productReadRepository;
            _companyWriteRepository = productWriteRepository;
        }

        public async Task<UpdateCompanyCommandResponse> Handle(UpdateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            Company company = await _companyReadRepository.GetByIdAsync(request.Id);
            company.Name = request.Name;
            company.OrderStartTime = request.OrderStartTime;
            company.OrderEndTime = request.OrderEndTime;
            await _companyWriteRepository.SaveAsync();
            return new();
        }
    }
}
