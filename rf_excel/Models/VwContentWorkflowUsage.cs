using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class VwContentWorkflowUsage
{
    public string? ContentName { get; set; }

    public string ContentType { get; set; } = null!;

    public int? WorkflowId { get; set; }
}
