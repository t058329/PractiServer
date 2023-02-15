using System;
using System.Collections.Generic;

namespace HMO.Repositories.Entities;

public partial class Child
{
    public string ChildId { get; set; } = null!;

    public string ParentId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public virtual User Parent { get; set; } = null!;
}
