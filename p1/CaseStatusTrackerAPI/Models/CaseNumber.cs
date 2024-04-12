using System;
using System.Collections.Generic;

namespace CaseStatusTrackerAPI.Models;

public partial class CaseNumber
{
    public string CaseId { get; set; } = null!;

    public int? UserId { get; set; }

    public virtual ICollection<CaseStatus> CaseStatuses { get; set; } = new List<CaseStatus>();

    public virtual User? User { get; set; }
}
