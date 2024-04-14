using System;
using System.Collections.Generic;

namespace CaseStatusTrackerAPI;

public partial class CaseStatus
{
    public int StatusId { get; set; }

    public string? CaseId { get; set; }

    public string? CaseStatus1 { get; set; }

    public virtual CaseNumber? Case { get; set; }
}
