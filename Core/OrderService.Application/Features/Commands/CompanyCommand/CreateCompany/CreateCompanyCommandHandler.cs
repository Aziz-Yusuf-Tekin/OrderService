using MediatR;
using OrderService.Application.Repositories.CompanyRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.CompanyCommand.CreateCompany
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommandRequest, CreateCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;

        public CreateCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository)
        {
            _companyWriteRepository = companyWriteRepository;
        }

        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            await _companyWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                OrderStartTime = request.OrderStartTime,
                OrderEndTime = request.OrderEndTime,              
            });
            await _companyWriteRepository.SaveAsync();
            return new();
        }
    }
}
