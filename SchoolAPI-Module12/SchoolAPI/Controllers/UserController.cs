using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace SchoolAPI.Controllers {
    [Route("api/v1/users")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class UserController : ControllerBase {
        

        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper) {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;

        }

        [HttpGet(Name = "getAllUsers")]
        public IActionResult GetUsers() {

            var users = _repository.User.GetAllUsers(trackChanges: false);

            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);
            //uncomment the code below to test the global exception handling
            //throw new Exception("Exception");
            return Ok(userDto);
        }
        [HttpGet("{id}", Name = "getUserById")]
        public IActionResult GetUser(Guid id) {

            var user = _repository.User.GetUser(id, trackChanges: false); if (user == null) {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else {
                var userDto = _mapper.Map<UserDto>(user);
                return Ok(userDto);
            }

        }
        [HttpPost(Name = "createUser")]
        public IActionResult CreateUser([FromBody] UserForCreationDto user) {
            if (user == null) {
                _logger.LogError("UserForCreationDto object sent from client is null.");
                return BadRequest("CompanyForCreationDto object is null");
            }
            if (!ModelState.IsValid) {
                _logger.LogError("Invalid model state for the UserForCreationDto object");
                return UnprocessableEntity(ModelState);
            }

            var userEntity = _mapper.Map<User>(user);

            _repository.User.CreateUser(userEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<UserDto>(userEntity);

            return CreatedAtRoute("getUserById", new { UserId = userToReturn.UserId }, userToReturn);
        }
        [HttpPut("{UserId}")]
        public IActionResult UpdateUser(Guid UserId, [FromBody] UserForUpdateDto user) {
            if (user == null) {
                _logger.LogError("UserForUpdateDto object sent from client is null.");
                return BadRequest("UserForUpdateDto object is null");
            }
            if (!ModelState.IsValid) {
                _logger.LogError("Invalid model state for the UserForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }
            var userEntity = _repository.User.GetUser(UserId, trackChanges: true);
            if (userEntity == null) {
                _logger.LogInfo($"User with id: {UserId} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(user, userEntity);
            _repository.Save();

            return NoContent();
        }
        [HttpDelete("{UserId}")]
        public IActionResult DeleteUser(Guid UserId) {
            var user = _repository.User.GetUser(UserId, trackChanges: false);
            if (user == null) {
                _logger.LogInfo($"User with id: {UserId} doesn't exist in the database.");
                return NotFound();
            }

            _repository.User.DeleteUser(user);
            _repository.Save();

            return NoContent();
        }

    }
}