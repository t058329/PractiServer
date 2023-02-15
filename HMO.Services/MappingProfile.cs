using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HMO.Common.DTO_s;
using HMO.Repositories.Entities;

namespace HMO.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Child, ChildDto>().ReverseMap();
        }
    }
}