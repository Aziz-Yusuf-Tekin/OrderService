using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.CompanyCommand.CreateCompany
{
    public class CreateCompanyCommandRequest : IRequest<CreateCompanyCommandResponse>
    {
        public string Name { get; set; }
        public TimeSpan OrderStartTime { get; set; }
        public TimeSpan OrderEndTime { get; set; }
    }
}
