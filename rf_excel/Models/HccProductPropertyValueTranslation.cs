using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class HccProductPropertyValueTranslation
{
    public long ProductPropertyValueTranslationId { get; set; }

    public long ProductPropertyValueId { get; set; }

    public string Culture { get; set; } = null!;

    public string? PropertyLocalizableValue { get; set; }

    public virtual HccProductPropertyValue ProductPropertyValue { get; set; } = null!;
}
