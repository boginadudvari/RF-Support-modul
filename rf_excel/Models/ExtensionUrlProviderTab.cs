﻿using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class ExtensionUrlProviderTab
{
    public int ExtensionUrlProviderId { get; set; }

    public int PortalId { get; set; }

    public int TabId { get; set; }

    public bool IsActive { get; set; }
}
