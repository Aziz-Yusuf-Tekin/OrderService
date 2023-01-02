using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.CompanyCommand.DeleteCompany
{
    public class DeleteCompanyCommandRequest : IRequest<DeleteCompanyCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
