using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class AspnetSchemaVersion
{
    public string Feature { get; set; } = null!;

    public string CompatibleSchemaVersion { get; set; } = null!;

    public bool IsCurrentVersion { get; set; }
}
