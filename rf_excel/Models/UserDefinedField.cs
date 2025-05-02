using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class UserDefinedField
{
    public int UserDefinedFieldId { get; set; }

    public int ModuleId { get; set; }

    public string? FieldTitle { get; set; }

    public bool Visible { get; set; }

    public int FieldOrder { get; set; }

    public string FieldType { get; set; } = null!;

    public bool Required { get; set; }

    public string? Default { get; set; }

    public string? OutputSettings { get; set; }

    public string? InputSettings { get; set; }

    public string? ValidationRule { get; set; }

    public string? ValidationMessage { get; set; }

    public bool NormalizeFlag { get; set; }

    public string? HelpText { get; set; }

    public bool Searchable { get; set; }

    public bool ShowOnEdit { get; set; }

    public bool PrivateField { get; set; }

    public string? EditStyle { get; set; }

    public bool MultipleValues { get; set; }

    public virtual Module Module { get; set; } = null!;

    public virtual ICollection<UserDefinedDatum> UserDefinedData { get; set; } = new List<UserDefinedDatum>();

    public virtual ICollection<UserDefinedFieldSetting> UserDefinedFieldSettings { get; set; } = new List<UserDefinedFieldSetting>();
}
