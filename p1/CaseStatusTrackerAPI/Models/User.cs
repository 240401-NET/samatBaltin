using System;
using System.Collections.Generic;

namespace CaseStatusTrackerAPI.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<CaseNumber> CaseNumbers { get; set; } = new List<CaseNumber>();
}
