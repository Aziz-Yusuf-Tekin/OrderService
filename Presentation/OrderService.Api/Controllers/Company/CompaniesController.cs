using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Application.Features.Commands.CompanyCommand.CreateCompany;
using OrderService.Application.Features.Commands.CompanyCommand.DeleteCompany;
using OrderService.Application.Features.Commands.CompanyCommand.UpdateCompany;
using OrderService.Application.Features.Queries.CompanyQuery.GetAllCompany;
using OrderService.Application.Features.Queries.CompanyQuery.GetByIdCompany;
using OrderService.Application.Repositories.CompanyRepository;
using System.Net;

namespace OrderService.Api.Controllers.Company
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        readonly IMediator _mediator;
        private ICompanyReadRepository _companyReadRepository;

        public CompaniesController(IMediator mediator, ICompanyReadRepository companyReadRepository)
        {
            _mediator = mediator;
            _companyReadRepository = companyReadRepository;
        }

        /// <summary>
        /// Get All Company
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = _companyReadRepository.GetCompanyList();
            //GetAllCompanyQueryResponse response = await _mediator.Send(getAllCompanyQueryRequest);
            return Ok(res);
        }

        /// <summary>
        /// GetById an Company
        /// </summary>
        /// <param name="home"></param>
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdCompanyQueryRequest getByIdCompanyQueryRequest)
        {
            GetByIdCompanyQueryResponse response = await _mediator.Send(getByIdCompanyQueryRequest);
            return Ok(response);
        }

        /// <summary>
        /// Create an Company
        /// </summary>
        /// <param name="home"></param>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCompanyCommandRequest createCompanyCommandRequest)
        {
            CreateCompanyCommandResponse response = await _mediator.Send(createCompanyCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        /// <summary>
        /// Delete an Company
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCompanyCommandRequest deleteCompanyCommandRequest)
        {
            DeleteCompanyCommandResponse response = await _mediator.Send(deleteCompanyCommandRequest);
            return Ok();
        }

        /// <summary>
        /// Update an Company
        /// </summary>
        /// <param name="home"></param>
        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] UpdateCompanyCommandRequest updateCompanyCommandRequest)
        {
            UpdateCompanyCommandResponse response = await _mediator.Send(updateCompanyCommandRequest);
            return Ok();
        }
    }
}
