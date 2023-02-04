using MediatR;
using OrderService.Application.Repositories.CompanyRepository;
using OrderService.Application.Repositories.OrderRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Commands.OrderCommand.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        readonly IOrderWriteRepository _orderWriteRepository;
        readonly ICompanyReadRepository _companyReadRepository;

        public CreateOrderCommandHandler(IOrderWriteRepository orderWriteRepository, ICompanyReadRepository companyReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _companyReadRepository = companyReadRepository;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var orderStartTime = _companyReadRepository.Table.Select(c => c.OrderStartTime).FirstOrDefault();
            var orderEndTime = _companyReadRepository.Table.Select(c => c.OrderEndTime).FirstOrDefault();
           // var approvalStatus = _companyReadRepository.Table.Select(c => c.ApprovalStatus).FirstOrDefault();


            if (DateTime.Now > orderStartTime && orderEndTime > DateTime.Now)
            {
                await _orderWriteRepository.AddAsync(new()
                {
                    CustomerId = request.CustomerId,
                    ProductId = request.ProductId,
                });
            }

            await _orderWriteRepository.SaveAsync();
            return new();
        }
    }
}
