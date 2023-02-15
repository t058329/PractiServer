using System;
using System.Collections.Generic;

namespace HMO.Repositories.Entities;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Kind { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string Hmo { get; set; } = null!;

    public virtual ICollection<Child> Children { get; } = new List<Child>();
}
