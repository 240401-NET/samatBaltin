using System;
using System.Collections.Generic;

namespace CaseStatusTrackerAPI;

public partial class Case
{
    public string ReceiptNumber { get; set; } = null!;

    public string? FormType { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<CaseStatus> CaseStatuses { get; set; } = new List<CaseStatus>();

    public virtual User? User { get; set; }
}
