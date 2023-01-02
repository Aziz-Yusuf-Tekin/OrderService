using MediatR;
using OrderService.Application.Repositories.CompanyRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.CompanyCommand.DeleteCompany
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommandRequest, DeleteCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;

        public DeleteCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository)
        {
            _companyWriteRepository = companyWriteRepository;
        }

        public async Task<DeleteCompanyCommandResponse> Handle(DeleteCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            await _companyWriteRepository.RemoveAsync(request.Id);
            await _companyWriteRepository.SaveAsync();
            return new();
        }
    }
}
