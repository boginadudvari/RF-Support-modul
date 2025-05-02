using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class TaxonomyScopeType
{
    public int ScopeTypeId { get; set; }

    public string? ScopeType { get; set; }

    public virtual ICollection<TaxonomyVocabulary> TaxonomyVocabularies { get; set; } = new List<TaxonomyVocabulary>();
}
