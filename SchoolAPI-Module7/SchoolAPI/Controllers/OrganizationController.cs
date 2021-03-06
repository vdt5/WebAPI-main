using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using AutoMapper;
using Entities.DataTransferObjects;

namespace SchoolAPI.Controllers {
    [Route("api/organizations")]
    [ApiController]

    public class OrganizationsController : ControllerBase {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public OrganizationsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper) {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetOrganizations() {
            var organizations = _repository.Organization.GetAllOrganizations(trackChanges: false);

            var organizationDto = _mapper.Map<IEnumerable<OrganizationDto>>(organizations);

            return Ok(organizationDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrganization(Guid id) {
            var organization = _repository.Organization.GetOrganization(id, trackChanges: false);
            var organizationDto = _mapper.Map<OrganizationDto>(organization);
            return Ok(organizationDto);
        }
    }
}
