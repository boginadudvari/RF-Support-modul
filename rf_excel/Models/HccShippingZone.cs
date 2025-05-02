using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class HccShippingZone
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string Name { get; set; } = null!;

    public string Areas { get; set; } = null!;

    public virtual HccStore Store { get; set; } = null!;
}
