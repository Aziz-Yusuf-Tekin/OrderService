using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.CompanyCommand.UpdateCompany
{
    public class UpdateCompanyCommandRequest : IRequest<UpdateCompanyCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime OrderStartTime { get; set; }
        public DateTime OrderEndTime { get; set; }
    }
}
