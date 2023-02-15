using HMO.Common.DTO_s;
using HMO.Repositories.Entities;
using HMO.Services.Interfaces;
using HMO.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IdataService<UserDto> _userService;
        public UserController(IdataService<UserDto> userService)
        {
            _userService = userService;
        }

        
        [HttpGet]
        public async Task<List<UserDto>> Get()
        {
            return await _userService.GetAllAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<UserDto> Get(string id)
        {
            return await _userService.GetByIdAsync(id);
        }

        
        [HttpPost]
        public async Task<UserDto> Post([FromBody] UserPostModel user)
        {
            return await _userService.AddAsync(new UserDto { UserId=user.UserId,Firstname=user.Firstname,LastName=user.LastName,Kind=user.Kind,DateOfBirth=user.DateOfBirth,Hmo=user.Hmo});
            //return await _userService.AddAsync(new UserDto(user.UserId,user.Firstname,user.LastName,user.Kind,user.DateOfBirth,user.Hmo));

        }
        //[HttpPost]


        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody] UserPostModel user)
        {
            var q = new UserDto { UserId = user.UserId, Firstname = user.Firstname, LastName = user.LastName, Kind = user.Kind, DateOfBirth = user.DateOfBirth, Hmo = user.Hmo };
            await _userService.UpdateAsync(q);        
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
