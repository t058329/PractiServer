using HMO.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Common.DTO_s
{
    public class ChildDto
    {
        public string ChildId { get; set; } = null!;

        public string ParentId { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

       // public virtual User Parent { get; set; }
    }
}
