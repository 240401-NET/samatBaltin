using System;
using System.Collections.Generic;

namespace CaseStatusTrackerAPI;

public partial class CaseStatus
{
    public int StatusId { get; set; }

    public string? ReceiptNumber { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? CurrentaseStatusText { get; set; }

    public string? CurrentCaseStatusDesc { get; set; }

    public virtual Case? ReceiptNumberNavigation { get; set; }
}
