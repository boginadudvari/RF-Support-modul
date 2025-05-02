using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class SearchIndexer
{
    public int SearchIndexerId { get; set; }

    public string SearchIndexerAssemblyQualifiedName { get; set; } = null!;
}
