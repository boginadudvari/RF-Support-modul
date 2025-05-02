using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class UserDefinedDatum
{
    public int UserDefinedFieldId { get; set; }

    public int UserDefinedRowId { get; set; }

    public string? FieldValue { get; set; }

    public virtual UserDefinedField UserDefinedField { get; set; } = null!;

    public virtual UserDefinedRow UserDefinedRow { get; set; } = null!;
}
