using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class ExtensionUrlProviderSetting
{
    public int ExtensionUrlProviderId { get; set; }

    public int PortalId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;
}
