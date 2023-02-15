using HMO.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Common.DTO_s
{
    public class UserDto
    {
        public string UserId { get; set; } = null!;

        public string Firstname { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Kind { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string Hmo { get; set; } = null!;

       // public virtual ICollection<Child> Children { get; } = new List<Child>();
    }
}
