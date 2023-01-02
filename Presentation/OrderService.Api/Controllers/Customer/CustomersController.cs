using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Application.Features.Commands.CustomerCommand.CreateCustomer;
using OrderService.Application.Features.Commands.CustomerCommand.DeleteCustomer;
using OrderService.Application.Features.Commands.CustomerCommand.UpdateCustomer;
using OrderService.Application.Features.Queries.CustomerQuery.GetAllCustomer;
using OrderService.Application.Features.Queries.CustomerQuery.GetByIdCustomer;
using System.Net;

namespace OrderService.Api.Controllers.Customer
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get All Customer
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllCustomer(GettAllCustomerQueryRequest getAllCustomerQueryRequest)
        {
            GettAllCustomerQueryResponse response = await _mediator.Send(getAllCustomerQueryRequest);
            return Ok(response);
        }

        /// <summary>
        /// GetById an Customer
        /// </summary>
        /// <param name="home"></param>
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdCustomerQueryRequest getByIdCustomerQueryRequest)
        {
            GetByIdCustomerQueryResponse response = await _mediator.Send(getByIdCustomerQueryRequest);
            return Ok(response);
        }

        /// <summary>
        /// Create an Customer
        /// </summary>
        /// <param name="home"></param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomerCommandRequest createCustomerCommandRequest)
        {
            CreateCustomerCommandResponse response = await _mediator.Send(createCustomerCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        /// <summary>
        /// Delete an Customer
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCustomerCommandRequest deleteCustomerCommandRequest)
        {
            DeleteCustomerCommandResponse response = await _mediator.Send(deleteCustomerCommandRequest);
            return Ok();
        }

        /// <summary>
        /// Update an Customer
        /// </summary>
        /// <param name="home"></param>
        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] UpdateCustomerCommandRequest updateCustomerCommandRequest)
        {
            UpdateCustomerCommandResponse response = await _mediator.Send(updateCustomerCommandRequest);
            return Ok();
        }
    }
}
