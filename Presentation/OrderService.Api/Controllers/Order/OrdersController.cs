using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Application.Features.Commands.OrderCommand.CreateOrder;
using OrderService.Application.Features.Commands.OrderCommand.DeleteOrder;
using OrderService.Application.Features.Commands.OrderCommand.UpdateOrder;
using OrderService.Application.Features.Queries.OrderQuery.GetAllOrder;
using OrderService.Application.Features.Queries.OrderQuery.GetByIdOrder;
using System.Net;

namespace OrderService.Api.Controllers.Order
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get All Order
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult>GettAllOrder(GettAllOrderQueryRequest gettAllOrderQueryRequest)
        {
            GettAllOrderQueryResponse response = await _mediator.Send(gettAllOrderQueryRequest);
            return Ok();
        }

        /// <summary>
        /// GetById Order
        /// </summary>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdOrderQueryRequest getByIdOrderQueryRequest)
        {
            GetByIdOrderQueryResponse response = await _mediator.Send(getByIdOrderQueryRequest);
            return Ok(response);
        }

        /// <summary>
        /// Create an Order
        /// </summary>
        /// <param name="home"></param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateOrderCommandRequest createOrderCommandRequest)
        {
            CreateOrderCommandResponse response = await _mediator.Send(createOrderCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        /// <summary>
        /// Delete an Order
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteOrderCommandRequest deleteOrderCommandRequest)
        {
            DeleteOrderCommandResponse response = await _mediator.Send(deleteOrderCommandRequest);
            return Ok();
        }

        /// <summary>
        /// Update an Order
        /// </summary>
        /// <param name="home"></param>
        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] UpdateOrderCommandRequest updateOrderCommandRequest)
        {
            UpdateOrderCommandResponse response = await _mediator.Send(updateOrderCommandRequest);
            return Ok();
        }
    }
}
