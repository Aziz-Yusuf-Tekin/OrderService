using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Application.Features.Commands.ProductCommand.CreateProduct;
using OrderService.Application.Features.Commands.ProductCommand.DeleteProduct;
using OrderService.Application.Features.Commands.ProductCommand.UpdateProduct;
using OrderService.Application.Features.Queries.ProductQuery.GetByIdProduct;
using OrderService.Application.Features.Queries.ProductQuery.GettAllProduct;
using OrderService.Application.Repositories.ProductRepository;
using System.Net;

namespace OrderService.Api.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly IMediator _mediator;
        private IProductReadRepository _productsReadRepository;

        public ProductsController(IMediator mediator, IProductReadRepository productReadRepository)
        {
            _mediator = mediator;
            _productsReadRepository = productReadRepository;
        }

        /// <summary>
        /// Get All Product By Company
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllProductByCompany(Guid id)
        {
            var res = _productsReadRepository.GetAllProductByCompany(id);
            //GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(res);
        }

        /// <summary>
        /// GetById an Product
        /// </summary>
        /// <param name="home"></param>
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);
        }

        /// <summary>
        /// Create an Product
        /// </summary>
        /// <param name="home"></param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        /// <summary>
        /// Delete an Product
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProductCommandRequest deleteProductCommandRequest)
        {
            DeleteProductCommandResponse response = await _mediator.Send(deleteProductCommandRequest);
            return Ok();
        }

        /// <summary>
        /// Update an Product
        /// </summary>
        /// <param name="home"></param>
        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] UpdateCompanyCommandRequest updateProductCommandRequest)
        {
            UpdateCompanyCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }
    }
}
