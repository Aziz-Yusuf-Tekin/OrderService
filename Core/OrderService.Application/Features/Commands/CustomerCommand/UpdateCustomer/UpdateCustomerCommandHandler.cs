using MediatR;
using OrderService.Application.Repositories.CustomerRepository;
using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.CustomerCommand.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, UpdateCustomerCommandResponse>
    {
        readonly ICustomerWriteRepository _customerWriteRepository;
        readonly ICustomerReadRepository _customerReadRepository;

        public UpdateCustomerCommandHandler(ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            Customer customer = await _customerReadRepository.GetByIdAsync(request.Id);
            customer.Name = request.Name;
            await _customerWriteRepository.SaveAsync();
            return new();
        }
    }
}
