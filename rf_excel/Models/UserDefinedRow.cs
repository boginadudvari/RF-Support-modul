using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class UserDefinedRow
{
    public int UserDefinedRowId { get; set; }

    public int ModuleId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Module Module { get; set; } = null!;

    public virtual ICollection<UserDefinedDatum> UserDefinedData { get; set; } = new List<UserDefinedDatum>();
}
