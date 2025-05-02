using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class VwMasterPortal
{
    public int PortalId { get; set; }

    public int? PortalGroupId { get; set; }

    public int MasterPortalId { get; set; }
}
