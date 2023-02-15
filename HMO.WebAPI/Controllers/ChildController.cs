using HMO.Common.DTO_s;
using HMO.Services.Interfaces;
using HMO.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IdataService<ChildDto> _childService;
        public ChildController(IdataService<ChildDto> childService)
        {
            _childService = childService;
        }


        [HttpGet]
        public async Task<List<ChildDto>> Get()
        {
            return await _childService.GetAllAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ChildDto> Get(string id)
        {
            return await _childService.GetByIdAsync(id);
        }

        
        [HttpPost]
        public async Task<ChildDto> Post([FromBody] ChildPostModel child)
        {
            return await _childService.AddAsync(new ChildDto { ChildId = child.ChildId, ParentId = child.ParentId, FirstName = child.FirstName, DateOfBirth = child.DateOfBirth });
        }

        
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ChildPostModel child)
        {
            var q = new ChildDto { ChildId = child.ChildId, ParentId = child.ParentId, FirstName = child.FirstName, DateOfBirth = child.DateOfBirth };
            await _childService.UpdateAsync(q);
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _childService.DeleteAsync(id);
        }
    }
}
