using AutoMapper;
using HMO.Common.DTO_s;
using HMO.Repositories.Entities;
using HMO.Repositories.Interfaces;
using HMO.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Services
{
    public class UserService : IdataService<UserDto>
    {
 

        private readonly IDataRepository<User> dataRepository;
        private readonly IMapper mapper;
        public UserService(IDataRepository<User> dataRepository, IMapper mapper)
        {
            this.dataRepository = dataRepository;
            this.mapper = mapper;
        }

        public async Task<UserDto> AddAsync(UserDto entity)
        {
            User newUser=mapper.Map<User>(entity);
            var n=await dataRepository.AddAsync(newUser);
            var newOne = mapper.Map<UserDto>(n);
            return newOne;
        }

        public async Task DeleteAsync(string id)
        {
            await dataRepository.DeleteAsync(id);
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
           return mapper.Map<List<UserDto>>(await dataRepository.GetAllAsync());
        }

        public async Task<UserDto> GetByIdAsync(string id)
        {
            return mapper.Map<UserDto>(await dataRepository.GetByIdAsync(id));
        }

        public async Task<UserDto> UpdateAsync(UserDto entity)
        {
            var q=await dataRepository.UpdateAsync(mapper.Map<User>(entity));
            return mapper.Map<UserDto> (q);
        }
    }
}
