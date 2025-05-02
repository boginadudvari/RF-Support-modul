using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class UserDefinedFieldSetting
{
    public int FieldId { get; set; }

    public string SettingName { get; set; } = null!;

    public string? SettingValue { get; set; }

    public virtual UserDefinedField Field { get; set; } = null!;
}
