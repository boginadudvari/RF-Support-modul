using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class HccSearchQuery
{
    public string Bvin { get; set; } = null!;

    public string QueryPhrase { get; set; } = null!;

    public string ShopperId { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
