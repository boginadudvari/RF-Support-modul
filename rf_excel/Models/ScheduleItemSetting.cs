using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class ScheduleItemSetting
{
    public int ScheduleId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;
}
