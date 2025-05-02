using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class PersonaBarMenuDefaultPermission
{
    public int Id { get; set; }

    public int MenuId { get; set; }

    public string RoleNames { get; set; } = null!;

    public virtual PersonaBarMenu Menu { get; set; } = null!;
}
