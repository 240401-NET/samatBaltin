using System;
using System.Collections.Generic;

namespace CaseStatusTrackerAPI;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Case> Cases { get; set; } = new List<Case>();
}
